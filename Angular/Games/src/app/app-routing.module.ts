import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: "checkers",
    loadChildren: () => import('./checkers/checkers.module').then(m => m.CheckersModule)
  },
  
  {
    path: "chess",
    loadChildren: () => import('./chess/chess.module').then(m => m.ChessModule)
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
