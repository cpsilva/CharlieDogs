import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { IndexComponent } from 'app/views/index/index.component';
import { HomeComponent } from 'app/views/home/home.component';
import { CaesComponent } from 'app/views/caes/caes.component';
import { DetalheCaoComponent } from 'app/views/detalhe-cao/detalhe-cao.component';
import { FinalizarPedidoComponent } from 'app/views/finalizar-pedido/finalizar-pedido.component';

const routes: Routes = [
  {
    path: 'home',
    component: HomeComponent
  },
  {
    path: 'canil',
    component: CaesComponent
  },
  {
    path: 'detalhe-cao/:id',
    component: DetalheCaoComponent
  },
  {
    path: 'finalizar-pedido',
    component: FinalizarPedidoComponent
  },

  { path: '', component: HomeComponent, pathMatch: 'full' },

  { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
