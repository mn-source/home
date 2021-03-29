import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SensorsRootComponent } from './components/sensors-root/sensors-root.component';
import { HttpClientModule } from '@angular/common/http';
import { SensorsRoutingModule } from './sensors.routing.module';
import { SensorsEditComponent } from './components/sensors-edit/sensors-edit.component';
import { SensorsListComponent } from './components/sensors-list/sensors-list.component';
import { ReactiveFormsModule } from '@angular/forms';
import { GridModule } from '@progress/kendo-angular-grid';
import { IconsModule } from '@progress/kendo-angular-icons';
import { ButtonsModule } from '@progress/kendo-angular-buttons';
@NgModule({
  imports: [
    CommonModule,
    SensorsRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    GridModule,
    IconsModule,
    ButtonsModule,
  ],
  declarations: [SensorsRootComponent, SensorsListComponent, SensorsEditComponent],
})
export class SensorsModule { }
