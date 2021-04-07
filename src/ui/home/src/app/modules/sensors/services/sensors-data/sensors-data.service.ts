import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { SensorModel } from '../../models/sensor.model';

@Injectable({
  providedIn: 'root'
})
export class SensorsDataService {
  constructor(private httpClient: HttpClient) { }


  getAllSensors(paginator: MatPaginator, sort: MatSort): Observable<SensorModel[]> {
    const result =
      this.httpClient
        .get(`https://localhost:5001/air/sensor/all?sort=${sort.active}&direction=${sort.direction}&page=${paginator.pageIndex}&pagesize=${paginator.pageSize}`);
    return result.pipe(map((response: any) => {
      return response.map((element: any) => {
        return {
          idString: element.idString,
          sensorName: element.sensorName,
          type: element.type,
          client: element.client,
          sensorApiAddress: element.sensorApiAddress,
          isActive: element.isActive
        };
      });
    }));
  }


}
