import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { SensorModel } from '../../models/sensor.model';

@Injectable({
  providedIn: 'root'
})
export class SensorsDataService {

  constructor(private httpClient: HttpClient) { }

  getAllSensors(): Observable<SensorModel> {
    const result = this.httpClient.get();
  }


}
