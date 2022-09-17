import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CrazyhouseLeaderboardComponent } from './crazyhouse-leaderboard/crazyhouse-leaderboard.component';
import { CrazyhouseMenuComponent } from './crazyhouse-menu/crazyhouse-menu.component';

const routes: Routes = [
  {
    path: "",
    component: CrazyhouseMenuComponent,
    children: 
    [
      {
        path: "leaderboard",
        component: CrazyhouseLeaderboardComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CrazyhouseRoutingModule { }
