import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ConfigurationRootComponent } from './components/configuration-root/configuration-root.component';


const routes: Routes = [
  {
    path: '',
    component: ConfigurationRootComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ConfigurationRoutingModule { }
