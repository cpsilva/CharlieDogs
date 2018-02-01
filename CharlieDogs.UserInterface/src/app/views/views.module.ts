import { CaesComponent } from './caes/caes.component';
import { CaoComponent } from './caes/cao/cao.component';
import { CommonModule } from '@angular/common';
import { DetalheCaoComponent } from './detalhe-cao/detalhe-cao.component';
import { FinalizarPedidoComponent } from './finalizar-pedido/finalizar-pedido.component';
import { FormsModule } from '@angular/forms';
import { HomeComponent } from './home/home.component';
import { IndexComponent } from 'app/views/index/index.component';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { SharedModule } from 'app/shared/shared.module';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    RouterModule,
    SharedModule
  ],
  declarations: [
    IndexComponent,
    HomeComponent,
    CaesComponent,
    CaoComponent,
    DetalheCaoComponent,
    FinalizarPedidoComponent
  ]
})
export class ViewsModule { }
