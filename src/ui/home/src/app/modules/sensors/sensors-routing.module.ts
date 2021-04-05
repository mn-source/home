import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SensorRootComponent } from './components/sensor-root/sensor-root.component';

const routes: Routes = [{ path: '', component: SensorRootComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SensorRoutingModule { }
