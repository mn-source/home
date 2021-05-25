import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { FormControl } from '@angular/forms';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable } from '@angular/material/table';
import { timer } from 'rxjs';
import { SensorClient, SensorModel, SensorType } from '../../models/sensor.model';
import { SensorsDataService } from '../../services/sensors-data/sensors-data.service';
import { SensorsListDataSource } from './sensors-list.datasource';

@Component({
  selector: 'home-sensors-list',
  templateUrl: './sensors-list.component.html',
  styleUrls: ['./sensors-list.component.scss']
})
export class SensorsListComponent implements AfterViewInit {
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatTable) table!: MatTable<SensorModel>;
  dataSource: SensorsListDataSource;
  SensorType = SensorType;
  SensorClient = SensorClient;
  /** Columns displayed in the table. Columns IDs can be added, removed, or reordered. */
  displayedColumns = ['idString', 'sensorName', 'type', 'client', 'sensorApiAddress', 'isActive'];

  constructor(sensorsDataService: SensorsDataService) {
    this.dataSource = new SensorsListDataSource(sensorsDataService);
  }

  ngAfterViewInit(): void {
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
    this.table.dataSource = this.dataSource;
  }
}
