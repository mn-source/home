using Home.Base.Base.Entity;
using Home.Base.Base.Service;
using Home.Base.Key.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home.Client.Api.Controllers.Base
{
    [Controller]
    public abstract class CRUDController<T, TKey>(IService<T, TKey> service, IKeyService<TKey> keyService) : BaseController where T : BaseEntity<TKey>
    {
        private readonly IService<T, TKey> service = service;
        private readonly IKeyService<TKey> keyService = keyService;

        [HttpPut]
        public async Task<IActionResult> CreateAsync(T data)
        {
            try
            {
                await service.AddAsync(data);
                return Ok(new { message = "Value added" });
            }
            catch (Exception exception)
            {
                var result = new ObjectResult(exception);
                return StatusCode(500, result);
            }
        }

        [HttpGet("item")]
        public async Task<ActionResult<T>> GetAsync(string id)
        {
            try
            {
                var entityId = keyService.ParseKey(id);
                var data = await service.GetAsync(entityId);
                if (data != null)
                {
                    data.IdString = keyService.GetKeyString(data.Id);
                    return Ok(data);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception exception)
            {
                var result = new ObjectResult(exception);
                return StatusCode(500, result);
            }

        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<T>>> GetAllAsync()
        {
            try
            {
                var data = default(IEnumerable<T>);
                data = await service.GetAllAsync();
                var responseData = data.Select(b =>
                {
                    b.IdString = keyService.GetKeyString(b.Id);
                    return b;
                });
                return Ok(responseData);
            }
            catch (Exception exception)
            {
                var result = new ObjectResult(exception);
                return StatusCode(500, result);
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAsync(string id, T data)
        {
            try
            {
                var entityId = keyService.ParseKey(id);
                await service.UpdateAsync(entityId, data);
                var updatedData = await service.GetAsync(entityId);
                return Ok(new { message = "Value updated", data = updatedData });
            }
            catch (Exception exception)
            {
                var result = new ObjectResult(exception);
                return StatusCode(500, result);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            try
            {
                var entityId = keyService.ParseKey(id);
                await service.DelateAsync(entityId);
                return Ok(new { message = "Value removed" });
            }
            catch (Exception exception)
            {
                var result = new ObjectResult(exception);
                return StatusCode(500, result);
            }
        }
    }
}
