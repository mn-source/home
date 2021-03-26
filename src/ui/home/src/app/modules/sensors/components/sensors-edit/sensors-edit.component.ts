import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { SensorModel } from '../../models/sensor.model';

@Component({
  selector: 'home-sensors-edit',
  templateUrl: './sensors-edit.component.html',
  styleUrls: ['./sensors-edit.component.scss']
})
export class SensorsEditComponent implements OnInit {

  constructor(@Inject(MAT_DIALOG_DATA) public sensor: SensorModel) { }

  ngOnInit(): void {
  }

}
