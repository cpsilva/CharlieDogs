import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EnumPipe } from './enum.pipe';
import { FiltersPipe } from './filters.pipe';

@NgModule({
  imports: [
    CommonModule
  ],
  exports: [
    EnumPipe,
    FiltersPipe
  ],
  declarations: [
    EnumPipe,
    FiltersPipe
  ]
})
export class PipesModule { }
