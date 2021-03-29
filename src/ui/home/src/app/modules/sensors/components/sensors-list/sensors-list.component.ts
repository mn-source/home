import { Component, OnInit } from '@angular/core';
import { SensorClient, SensorModel, SensorType } from '../../models/sensor.model';
import { SensorsDataService } from '../../services/data/sensors-data.service';
import { SensorsEditComponent } from '../sensors-edit/sensors-edit.component';

@Component({
  selector: 'home-sensors-list',
  templateUrl: './sensors-list.component.html',
  styleUrls: ['./sensors-list.component.scss']
})
export class SensorsListComponent implements OnInit {
  sensors: SensorModel[] = [];
  SensorType = SensorType;
  SensorClient = SensorClient;

  displayedColumns: string[] = [
    'sensorName',
    'type',
    'client',
    'sensorApiAddress',
    'isActive',
    'editCommand',
    'removeCommand'
  ];

  constructor(
    private sensorsDataService: SensorsDataService,
  ) { }

  ngOnInit(): void {
    this.loadSensors();
  }

  loadSensors(): void {
    this.sensorsDataService.getAllSensors().subscribe(b => this.sensors = b);


  }


  editSensor(sensor: SensorModel): void {
    console.log('sensor edit', sensor);
  }


  deleteSensor(sensor: SensorModel): void {
    console.log('sensor delete', sensor);
  }

}
