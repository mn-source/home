import { Component, OnInit } from '@angular/core';
import { SensorsDataService } from '../../services/data/sensors-data.service';

@Component({
  selector: 'home-sensors-list',
  templateUrl: './sensors-list.component.html',
  styleUrls: ['./sensors-list.component.scss']
})
export class SensorsListComponent implements OnInit {

  constructor(private sensorsDataService: SensorsDataService) { }

  ngOnInit(): void {
  }

}
