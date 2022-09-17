import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Movie } from 'src/app/models/Movie';
import { CastService } from 'src/app/services/cast/cast.service';
import { MovieService } from 'src/app/services/movie/movie.service';

@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.css']
})
export class MovieDetailsComponent implements OnInit {

  movie:Movie = new Movie;
  
  id:number = 1;

  num:number = 60;

  constructor(private route:ActivatedRoute,
    private movie_service:MovieService,
    private cast_service:CastService) {}

  ngOnInit(): void {
    this.id = this.route.snapshot.params['id']; 
    


    this.movie_service.getMovieById(this.id).subscribe(data => {
      this.movie = data;
    })
    
    
  }



}
