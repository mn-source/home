import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    data: { name: 'Sensors' },
    path: 'sensors',
    loadChildren: () => import('./modules/sensors/sensors.module').then(m => m.SensorsModule)
  },
  {
    data: { name: 'Dashboard' },
    path: 'dashboard',
    loadChildren: () => import('./modules/dashboard/dashboard.module').then(m => m.DashboardModule)
  },
  {
    path: '',
    redirectTo: 'sensors',
    pathMatch: 'full'
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
