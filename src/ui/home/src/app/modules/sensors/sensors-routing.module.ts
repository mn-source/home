import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SensorsDashboardComponent } from './components/sensors-dashboard/sensors-dashboard.component';
import { SensorsListComponent } from './components/sensors-list/sensors-list.component';

const routes: Routes = [
    { path: 'dashboard', component: SensorsDashboardComponent },
  { path: 'list', component: SensorsListComponent },
  {
    path: '',
    redirectTo: 'dashboard',
    pathMatch: 'full'
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SensorRoutingModule { }
