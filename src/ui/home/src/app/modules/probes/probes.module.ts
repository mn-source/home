import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProbesRootComponent } from './components/probes-root/probes-root.component';
import { ProbesRoutingModule } from './probes.routing.module';

@NgModule({
  imports: [
    CommonModule,
    ProbesRoutingModule
  ],
  declarations: [ProbesRootComponent],
})
export class ProbesModule { }
