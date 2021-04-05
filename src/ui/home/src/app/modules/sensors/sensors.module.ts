import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SensorRootComponent } from './components/sensor-root/sensor-root.component';
import { SensorRoutingModule } from './sensors-routing.module';
import { SensorsListComponent } from './components/sensors-list/sensors-list.component';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  imports: [
    CommonModule,
    SensorRoutingModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    HttpClientModule,
  ],
  declarations: [SensorRootComponent, SensorsListComponent]
})
export class SensorsModule { }
