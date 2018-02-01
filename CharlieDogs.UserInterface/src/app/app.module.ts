import { BrowserModule } from '@angular/platform-browser';
import { NgModule, LOCALE_ID } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component'
import { LayoutModule } from 'app/layout/layout.module';
import { FormsModule } from '@angular/forms';
import { LocationStrategy, HashLocationStrategy } from '@angular/common';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    FormsModule,
    LayoutModule
  ],
  bootstrap: [AppComponent],
  providers: [
    { provide: LOCALE_ID, useValue: "pt-BR" },
    { provide: LocationStrategy, useClass: HashLocationStrategy }
  ]
})
export class AppModule { }
