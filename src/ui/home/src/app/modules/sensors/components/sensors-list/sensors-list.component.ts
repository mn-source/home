import { Component, OnInit } from '@angular/core';
import { SensorClient, SensorModel, SensorType } from '../../models/sensor.model';
import { SensorsDataService } from '../../services/data/sensors-data.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MatDialog } from '@angular/material/dialog';
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
    private snackBar: MatSnackBar,
    private sensorsDataService: SensorsDataService,
    public dialog: MatDialog
  ) { }

  ngOnInit(): void {
    this.loadSensors();
  }

  loadSensors(): void {
    this.sensorsDataService.getAllSensors().subscribe(b => this.sensors = b, e => this.reportError(e.message));


  }

  private reportError(message: string): void {
    this.snackBar.open(message, 'Close', {
      duration: 15000
    });
  }

  editSensor(sensor: SensorModel): void {
    const dialogRef = this.dialog.open(SensorsEditComponent, { data: sensor });

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }

}
