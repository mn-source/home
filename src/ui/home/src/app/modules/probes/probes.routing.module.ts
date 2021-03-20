import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProbesRootComponent } from './components/probes-root/probes-root.component';


const routes: Routes = [
  {
    path: '',
    component: ProbesRootComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProbesRoutingModule { }
