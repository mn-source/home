import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SensorRoutingModule } from './sensors-routing.module';
import { SensorsListComponent } from './components/sensors-list/sensors-list.component';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { HttpClientModule } from '@angular/common/http';
import { MatButtonToggleModule } from '@angular/material/button-toggle';
import { ReactiveFormsModule } from '@angular/forms';
import { SensorsDashboardComponent } from './components/sensors-dashboard/sensors-dashboard.component';
import { ProbeLatestComponent } from './components/probe-latest/probe-latest.component';
import { SensorEditComponent } from './components/sensor-edit/sensor-edit.component';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatIconModule } from '@angular/material/icon';
import { MatMenuModule } from '@angular/material/menu';

@NgModule({
  imports: [
    CommonModule,
    SensorRoutingModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    HttpClientModule,
    MatButtonToggleModule,
    ReactiveFormsModule,
    MatGridListModule,
    MatCardModule,
    MatMenuModule,
    MatIconModule,
    MatButtonModule,
  ],
  declarations: [SensorsListComponent, SensorsDashboardComponent, ProbeLatestComponent, SensorEditComponent]
})
export class SensorsModule { }
