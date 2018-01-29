import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ApplicationService } from 'app/shared/services/application.service';
import { ConverterService } from 'app/shared/services/converter.service';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [],
  providers: [
    ApplicationService,
    ConverterService
  ]
})
export class ServicesModule { }
