import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SensorsRootComponent } from './components/sensors-root/sensors-root.component';


const routes: Routes = [
  {
    path: '',
    component: SensorsRootComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SensorsRoutingModule { }
