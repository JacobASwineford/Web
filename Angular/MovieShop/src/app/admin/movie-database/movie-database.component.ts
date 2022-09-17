import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Movie } from 'src/app/models/Movie';
import { MovieService } from 'src/app/services/movie/movie.service';

@Component({
  selector: 'app-movie-database',
  templateUrl: './movie-database.component.html',
  styleUrls: ['./movie-database.component.css']
})
export class MovieDatabaseComponent implements OnInit {

  from_id:number = 1;
  modify_id:number = 0;
  delete_id:number = 0;

  movie:Movie = new Movie;

  constructor(private service:MovieService) { }

  ngOnInit(): void {
    this.service.getMovieById(1).subscribe(data => {
      this.movie = data;
    })
  }

  from() {
    this.service.getMovieById(this.from_id).subscribe(data => {
      this.movie = data;
      this.movie.id = undefined;
    });
  }

  add() {
    this.service.addMovie(this.movie).subscribe();
  }

  delete() {
    this.service.deleteMovie(this.delete_id).subscribe();
  }

  modify() {
    this.movie.id = this.modify_id;
    this.service.updateMovie(this.movie).subscribe();
  }

  reset() {
    this.movie = new Movie();
  }

}
