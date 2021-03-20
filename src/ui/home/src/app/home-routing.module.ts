import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'configuration',
    loadChildren: () => import('./modules/configuration/configuration.module').then(m => m.ConfigurationModule)
  },
  {
    path: 'probes',
    loadChildren: () => import('./modules/probes/probes.module').then(m => m.ProbesModule)
  },
  {
    path: 'sensors',
    loadChildren: () => import('./modules/sensors/sensors.module').then(m => m.SensorsModule)
  }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule { }
