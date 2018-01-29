import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { IndexComponent } from 'app/views/index/index.component';
import { HomeComponent } from './home/home.component';
import { CaesComponent } from './caes/caes.component';
import { CaoComponent } from './caes/cao/cao.component';
import { DetalheCaoComponent } from './detalhe-cao/detalhe-cao.component';

@NgModule({
    imports: [
        CommonModule,
        RouterModule
    ],
    declarations: [
        IndexComponent,
        HomeComponent,
        CaesComponent,
        CaoComponent,
        DetalheCaoComponent
    ]
})
export class ViewsModule { }