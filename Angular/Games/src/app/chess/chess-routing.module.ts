import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ChessMenuComponent } from './chess-menu/chess-menu.component';

const routes: Routes = [
  {
    path: "",
    component: ChessMenuComponent,
    children: 
    [
      {
        path: "standard",
        loadChildren: () => import('./standard/standard.module').then(m => m.StandardModule)
      },

      {
        path: "crazyhouse",
        loadChildren: () => import('./crazyhouse/crazyhouse.module').then(m => m.CrazyhouseModule)
      },

      {
        path: "fogofwar",
        loadChildren: () => import('./fogofwar/fogofwar.module').then(m => m.FogofwarModule)
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ChessRoutingModule { }
