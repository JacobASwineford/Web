import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { MovieDatabaseComponent } from './movie-database/movie-database.component';
import { CastDatabaseComponent } from './cast-database/cast-database.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    MovieDatabaseComponent,
    CastDatabaseComponent
  ],
  imports: [
    CommonModule,
    AdminRoutingModule,
    FormsModule
  ]
})
export class AdminModule { }
