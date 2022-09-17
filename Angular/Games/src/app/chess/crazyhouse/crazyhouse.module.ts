import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CrazyhouseRoutingModule } from './crazyhouse-routing.module';
import { CrazyhouseMenuComponent } from './crazyhouse-menu/crazyhouse-menu.component';
import { CrazyhouseLeaderboardComponent } from './crazyhouse-leaderboard/crazyhouse-leaderboard.component';


@NgModule({
  declarations: [
    CrazyhouseMenuComponent,
    CrazyhouseLeaderboardComponent
  ],
  imports: [
    CommonModule,
    CrazyhouseRoutingModule
  ]
})
export class CrazyhouseModule { }
