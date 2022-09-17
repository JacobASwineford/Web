import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ChessRoutingModule } from './chess-routing.module';
import { ChessMenuComponent } from './chess-menu/chess-menu.component';


@NgModule({
  declarations: [
    ChessMenuComponent
  ],
  imports: [
    CommonModule,
    ChessRoutingModule
  ]
})
export class ChessModule { }
