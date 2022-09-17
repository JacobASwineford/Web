import { Component, Input, OnInit } from '@angular/core';
import { CastService } from 'src/app/services/cast/cast.service';

@Component({
  selector: 'app-movie-cast-list',
  templateUrl: './movie-cast-list.component.html',
  styleUrls: ['./movie-cast-list.component.css']
})
export class MovieCastListComponent implements OnInit {

  @Input() public id:number = 1;

  cast_list:any = [];

  details_list:any = [];

  constructor(private service:CastService) { }

  ngOnInit(): void {
    this.service.getCastDetails(this.id).subscribe(data => {
      this.details_list = data;
    })
  }

}
