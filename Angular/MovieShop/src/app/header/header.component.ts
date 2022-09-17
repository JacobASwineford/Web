import { Component, OnInit } from '@angular/core';
import { GenreService } from '../services/genre/genre.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  username:string = "Placeholder";
  genres:any = [];

  constructor(private service:GenreService) { }

  ngOnInit(): void {
    this.service.getAllGenres().subscribe(data => {
      this.genres = data;
      console.log(this.genres[0]);
    })
  }

}
