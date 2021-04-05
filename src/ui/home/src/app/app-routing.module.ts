import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    data: { name: 'Probes' },
    path: 'probes',
     loadChildren: () => import('./modules/probes/probes.module').then(m => m.ProbesModule)
  },
  {
    data: { name: 'Sensors' },
    path: 'sensors',
    loadChildren: () => import('./modules/sensors/sensors.module').then(m => m.SensorsModule)
  },
  {
    data: { name: 'Dashboard' },
    path: 'dashboard',
    loadChildren: () => import('./modules/dashboard/dashboard.module').then(m => m.DashboardModule)
  }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
