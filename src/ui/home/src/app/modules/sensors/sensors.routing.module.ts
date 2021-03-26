import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SensorsEditComponent } from './components/sensors-edit/sensors-edit.component';
import { SensorsListComponent } from './components/sensors-list/sensors-list.component';


const routes: Routes = [
  {
    path: 'edit',
    component: SensorsEditComponent
  },
  {
    path: 'list',
    component: SensorsListComponent
  },
  { path: '', redirectTo: 'list', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SensorsRoutingModule { }
