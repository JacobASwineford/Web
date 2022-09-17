import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { StandardRoutingModule } from './standard-routing.module';
import { StandardMenuComponent } from './standard-menu/standard-menu.component';
import { StandardLeaderboardComponent } from './standard-leaderboard/standard-leaderboard.component';


@NgModule({
  declarations: [
    StandardMenuComponent,
    StandardLeaderboardComponent
  ],
  imports: [
    CommonModule,
    StandardRoutingModule
  ]
})
export class StandardModule { }
