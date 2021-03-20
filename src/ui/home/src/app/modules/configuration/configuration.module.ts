import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ConfigurationRootComponent } from './components/configuration-root/configuration-root.component';
import { ConfigurationRoutingModule } from './configuration.routing.module';

@NgModule({
  imports: [
    CommonModule,
    ConfigurationRoutingModule
  ],
  declarations: [ConfigurationRootComponent]
})
export class ConfigurationModule { }
