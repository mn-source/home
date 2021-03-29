import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { SensorClient, SensorModel, SensorType } from '../../models/sensor.model';

@Component({
  selector: 'home-sensors-edit',
  templateUrl: './sensors-edit.component.html',
  styleUrls: ['./sensors-edit.component.scss']
})
export class SensorsEditComponent implements OnInit {

  sensorForm = this.formBuilder.group({
    idString: ['', Validators.required],
    sensorName: ['', Validators.required],
    type: [SensorType.AirQuality],
    client: [SensorClient.Blebox],
    isActive: [true],
  });
  constructor(
    // @Inject(MAT_DIALOG_DATA) public sensor: SensorModel,
    private formBuilder: FormBuilder) { }

  ngOnInit(): void {
  }

  onSubmit(): void {

  }
}
