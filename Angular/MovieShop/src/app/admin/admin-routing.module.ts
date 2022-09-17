import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CastDatabaseComponent } from './cast-database/cast-database.component';
import { MovieDatabaseComponent } from './movie-database/movie-database.component';

const routes: Routes = [
  {
    path: "",
    children: 
    [
      {
        path: "movie",
        component: MovieDatabaseComponent
      },
      {
        path: "cast",
        component: CastDatabaseComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
