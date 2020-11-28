import { NgModule, NO_ERRORS_SCHEMA } from '@angular/core';
import { SharedModule } from './../shared/shared.module';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home.component';

@NgModule({
  declarations: [HomeComponent],
  imports: [
    CommonModule,
    SharedModule
  ],
  exports: [HomeComponent],
  schemas: [
    NO_ERRORS_SCHEMA
  ]
})
export class HomeModule { }

