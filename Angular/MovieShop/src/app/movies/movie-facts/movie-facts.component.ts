import { Component, Input, OnInit } from '@angular/core';
import { Movie } from 'src/app/models/Movie';

@Component({
  selector: 'app-movie-facts',
  templateUrl: './movie-facts.component.html',
  styleUrls: ['./movie-facts.component.css']
})
export class MovieFactsComponent implements OnInit {

  @Input() public movie?:Movie;

  constructor() { }

  ngOnInit(): void {
    
  }

}
