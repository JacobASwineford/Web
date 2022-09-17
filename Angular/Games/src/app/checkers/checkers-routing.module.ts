import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CheckersMenuComponent } from './checkers-menu/checkers-menu.component';

const routes: Routes = [
  {
    path: "",
    component: CheckersMenuComponent,
    children: 
    [
      {
        path: "standard",
        loadChildren: () => import('./standard/standard.module').then(m => m.StandardModule)
      },

      {
        path: "suicide",
        loadChildren: () => import('./suicide/suicide.module').then(m => m.SuicideModule)
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CheckersRoutingModule { }
