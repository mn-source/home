import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SensorsRootComponent } from './components/sensors-root/sensors-root.component';
import { HttpClientModule } from '@angular/common/http';
import { SensorsRoutingModule } from './sensors.routing.module';
import { SensorsEditComponent } from './components/sensors-edit/sensors-edit.component';
import { SensorsListComponent } from './components/sensors-list/sensors-list.component';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatDialogModule } from '@angular/material/dialog';

@NgModule({
  imports: [
    CommonModule,
    SensorsRoutingModule,
    HttpClientModule,
    MatSnackBarModule,
    MatTableModule,
    MatButtonModule,
    MatIconModule,
    MatDialogModule
  ],
  declarations: [SensorsRootComponent, SensorsListComponent, SensorsEditComponent],
})
export class SensorsModule { }
