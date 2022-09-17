import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FogofwarRoutingModule } from './fogofwar-routing.module';
import { FogofwarMenuComponent } from './fogofwar-menu/fogofwar-menu.component';
import { FogofwarLeaderboardComponent } from './fogofwar-leaderboard/fogofwar-leaderboard.component';


@NgModule({
  declarations: [
    FogofwarMenuComponent,
    FogofwarLeaderboardComponent
  ],
  imports: [
    CommonModule,
    FogofwarRoutingModule
  ]
})
export class FogofwarModule { }
