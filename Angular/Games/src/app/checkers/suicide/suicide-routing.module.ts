import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SuicideLeaderboardComponent } from './suicide-leaderboard/suicide-leaderboard.component';
import { SuicideMenuComponent } from './suicide-menu/suicide-menu.component';

const routes: Routes = [
  {
    path: "",
    component: SuicideMenuComponent,
    children: 
    [
      {
        path: "leaderboard",
        component: SuicideLeaderboardComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SuicideRoutingModule { }
