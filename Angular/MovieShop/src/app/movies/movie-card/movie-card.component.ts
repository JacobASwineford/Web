import { Component, Input, OnInit } from '@angular/core';
import { Movie } from 'src/app/models/Movie';
import { MovieService } from 'src/app/services/movie/movie.service';

@Component({
  selector: 'app-movie-card',
  templateUrl: './movie-card.component.html',
  styleUrls: ['./movie-card.component.css']
})
export class MovieCardComponent implements OnInit {

  @Input() public id:number = 1;
  movie:Movie = new Movie;

  constructor(private service:MovieService) {}

  ngOnInit(): void {
    this.service.getMovieById(this.id).subscribe(data => {
      console.log(data);
      this.movie = data;
    })
  }



}
