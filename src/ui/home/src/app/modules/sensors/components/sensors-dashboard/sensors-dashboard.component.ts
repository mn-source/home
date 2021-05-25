import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Observable, of } from 'rxjs';
import { HomeControl } from '../../models/home.control';
import { ProbeModel } from '../../models/probe.model';
import { SensorsDataService } from '../../services/sensors-data/sensors-data.service';

@Component({
  selector: 'home-sensors-dashboard',
  templateUrl: './sensors-dashboard.component.html',
  styleUrls: ['./sensors-dashboard.component.scss']
})
export class SensorsDashboardComponent implements OnInit {
  formGroup = this.fb.group(
    {
      sensor: new HomeControl({
        value: 'test',
        color: '#333'
      }, 'message', Validators.required)
    }
  );
  sensors$ = this.sensorsDataService.getAllSensors();
  constructor(
    private sensorsDataService: SensorsDataService,
    private fb: FormBuilder) { }

  ngOnInit(): void {
  }

  getSensorLatestProbe(sensorId: string | undefined): Observable<ProbeModel | null> {
    if (sensorId) {
      return this.sensorsDataService.getSensorLatestProbe(sensorId);
    }
    return of(null);
  }
}
