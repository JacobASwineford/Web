import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Movie } from 'src/app/models/Movie';
import { MovieService } from 'src/app/services/movie/movie.service';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.css']
})
export class MovieListComponent implements OnInit {

  movies:any = [];

  constructor(private route : ActivatedRoute,
    private service:MovieService) { }

  ngOnInit(): void {
    var genreName = this.route.snapshot.params['genreName'];
    console.log(genreName);
    this.service.getMoviesByGenreName(genreName).subscribe(data => {
      this.movies = data;
    })

  }

  

}
