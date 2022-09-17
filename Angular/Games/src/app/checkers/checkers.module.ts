import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CheckersRoutingModule } from './checkers-routing.module';
import { CheckersMenuComponent } from './checkers-menu/checkers-menu.component';


@NgModule({
  declarations: [
    CheckersMenuComponent
  ],
  imports: [
    CommonModule,
    CheckersRoutingModule
  ]
})
export class CheckersModule { }
