import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { StandardLeaderboardComponent } from './standard-leaderboard/standard-leaderboard.component';
import { StandardMenuComponent } from './standard-menu/standard-menu.component';

const routes: Routes = [
  {
    path: "",
    component: StandardMenuComponent,
    children: 
    [
      {
        path: "leaderboard",
        component: StandardLeaderboardComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class StandardRoutingModule { }
