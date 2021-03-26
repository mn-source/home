import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { SensorModel } from '../../models/sensor.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SensorsDataService {

  constructor(private httpClient: HttpClient) { }

  getAllSensors(): Observable<SensorModel[]> {
    const result = this.httpClient.get('https://localhost:5001/air/sensor/all');
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
