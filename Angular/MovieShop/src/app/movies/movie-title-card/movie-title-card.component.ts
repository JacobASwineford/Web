import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Movie } from 'src/app/models/Movie';
import { MovieService } from 'src/app/services/movie/movie.service';

@Component({
  selector: 'app-movie-title-card',
  templateUrl: './movie-title-card.component.html',
  styleUrls: ['./movie-title-card.component.css']
})
export class MovieTitleCardComponent implements OnInit {

  @Input() public movie?:Movie;
  rating:number = 9.2;
  genre:any = [];

  constructor(private service:MovieService,
    private route:ActivatedRoute) {}

  ngOnInit(): void {
    var id = this.route.snapshot.params['id'];
    this.service.getGenresByMovie(id).subscribe(data => {
      this.genre = data;
      console.log(this.genre);
    })
  }

}
