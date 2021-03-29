import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RootComponent } from './components/root/root.component';
import { HomeRoutingModule } from './home-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { ButtonsModule } from '@progress/kendo-angular-buttons';
import { DialogsModule } from '@progress/kendo-angular-dialog';
import { GridModule } from '@progress/kendo-angular-grid';
import { IconsModule } from '@progress/kendo-angular-icons';





@NgModule({
  declarations: [
    RootComponent
  ],
  imports: [
    CommonModule,
    BrowserModule,
    HomeRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ButtonsModule,
    DialogsModule,
    GridModule,
    IconsModule
  ],
  providers: [],
  bootstrap: [RootComponent]
})
export class HomeModule { }
