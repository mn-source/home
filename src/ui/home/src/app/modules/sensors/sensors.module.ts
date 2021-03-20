import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SensorsRootComponent } from './components/sensors-root/sensors-root.component';
import { SensorsRoutingModule } from './sensros.routing.module';

@NgModule({
  imports: [
    CommonModule,
    SensorsRoutingModule
  ],
  declarations: [SensorsRootComponent],
})
export class SensorsModule { }
