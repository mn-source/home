import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ProbeModel } from '../../models/probe.model';
import { SensorModel } from '../../models/sensor.model';

@Injectable({
  providedIn: 'root'
})
export class SensorsDataService {
  private hostAir = 'https://localhost:5001/air';
  constructor(private httpClient: HttpClient) { }


  getAllSensors(): Observable<SensorModel[]> {
    const result =
      this.httpClient
        .get(`${this.hostAir}/sensor/all`);
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

  getAllTableSensors(paginator: MatPaginator, sort: MatSort): Observable<SensorModel[]> {
    const result =
      this.httpClient
        .get(`${this.hostAir}/sensor/all?sort=${sort.active}&direction=${sort.direction}&page=${paginator.pageIndex}&pagesize=${paginator.pageSize}`);
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


  getSensorLatestProbe(sensorId: string): Observable<ProbeModel> {
    const result =
      this.httpClient
        .get(`${this.hostAir}/probe/sensor/${sensorId}/latest`);
    return result.pipe(map((response: any) => {
      return {
        idString: response.idString,
        probeDate: response.probeDate,
        temperatureCelcius: response.temperatureCelcius,
        humidityPercent: response.humidityPercent,
        pm1: response.pm1,
        pm2_5: response.pm2_5,
        pm10: response.pm10,
        caqi: response.caqi
      };
    }));
  }

}
