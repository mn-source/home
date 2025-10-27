﻿// Copyright (C) Aqnkla - All Rights Reserved
// Unauthorized copying of this file, via any medium is strictly prohibited
// Proprietary and confidential.
// Written by Mariusz Nowak <dev@sorgo.net>, 2019
using Home.Base.Base.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Home.Base.Base.Service;

public interface IService<T, TKey> where T : BaseEntity<TKey>
{
    Task<T> GetAsync(TKey id);
    Task AddAsync(T value);
    Task<T> UpdateAsync(TKey id, T value);
    Task DelateAsync(TKey id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<IEnumerable<T>> GetAllAsync(int page, int pagesize);
    Task<IEnumerable<T>> GetAllAsync(string sortActive, string direction, int page, int pagesize);
}
