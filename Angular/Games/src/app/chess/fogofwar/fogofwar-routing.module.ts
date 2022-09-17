import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FogofwarLeaderboardComponent } from './fogofwar-leaderboard/fogofwar-leaderboard.component';
import { FogofwarMenuComponent } from './fogofwar-menu/fogofwar-menu.component';

const routes: Routes = [
  {
    path: "",
    component: FogofwarMenuComponent,
    children: 
    [
      {
        path: "leaderboard",
        component: FogofwarLeaderboardComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FogofwarRoutingModule { }
