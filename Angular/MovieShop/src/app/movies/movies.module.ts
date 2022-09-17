import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MoviesRoutingModule } from './movies-routing.module';
import { MovieCardComponent } from './movie-card/movie-card.component';
import { MovieDetailsComponent } from './movie-details/movie-details.component';
import { MovieListComponent } from './movie-list/movie-list.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MovieFactsComponent } from './movie-facts/movie-facts.component';
import { MovieCastListComponent } from './movie-cast-list/movie-cast-list.component';
import { MovieTitleCardComponent } from './movie-title-card/movie-title-card.component';
import { SummaryLimitPipe } from '../pipes/summary-limit.pipe';


@NgModule({
  declarations: [
    MovieCardComponent,
    MovieDetailsComponent,
    MovieListComponent,
    MovieFactsComponent,
    MovieCastListComponent,
    MovieTitleCardComponent,
    SummaryLimitPipe
  ],
  imports: [
    CommonModule,
    MoviesRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class MoviesModule { }
