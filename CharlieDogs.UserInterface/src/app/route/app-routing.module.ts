import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { IndexComponent } from 'app/views/index/index.component';
import { HomeComponent } from 'app/views/home/home.component';
import { CaesComponent } from 'app/views/caes/caes.component';
import { DetalheCaoComponent } from 'app/views/detalhe-cao/detalhe-cao.component';

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
    path: 'detalhe-cao',
    component: DetalheCaoComponent
  },

  { path: '', component: IndexComponent, pathMatch: 'full' },

  { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
