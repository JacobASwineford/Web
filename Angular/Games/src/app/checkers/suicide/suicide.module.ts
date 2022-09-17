import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SuicideRoutingModule } from './suicide-routing.module';
import { SuicideMenuComponent } from './suicide-menu/suicide-menu.component';
import { SuicideLeaderboardComponent } from './suicide-leaderboard/suicide-leaderboard.component';


@NgModule({
  declarations: [
    SuicideMenuComponent,
    SuicideLeaderboardComponent
  ],
  imports: [
    CommonModule,
    SuicideRoutingModule
  ]
})
export class SuicideModule { }
