import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProbesRoutingModule } from './probes-routing.module';
import { ProbesRootComponent } from './components/probes-root/probes-root.component';
import { ProbesListComponent } from './components/probes-list/probes-list.component';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';


@NgModule({
  declarations: [ProbesRootComponent, ProbesListComponent],
  imports: [
    CommonModule,
    ProbesRoutingModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule
  ]
})
export class ProbesModule { }
