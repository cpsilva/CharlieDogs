import { NgModule, LOCALE_ID } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ServicesModule } from 'app/shared/services/services.module';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  imports: [
    CommonModule,
    HttpClientModule,
    ServicesModule,
  ],
  declarations: [],
  providers: [
    {
      provide: LOCALE_ID,
      useValue: navigator.language
    }
  ]
})
export class SharedModule { }
