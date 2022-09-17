import { Component, OnInit } from '@angular/core';
import { Cast } from 'src/app/models/Cast';
import { CastService } from 'src/app/services/cast/cast.service';

@Component({
  selector: 'app-cast-database',
  templateUrl: './cast-database.component.html',
  styleUrls: ['./cast-database.component.css']
})
export class CastDatabaseComponent implements OnInit {

  from_id:number = 1;
  delete_id:number = 0;
  modify_id:number = 0;

  cast:Cast = new Cast;

  constructor(private service:CastService) { }

  ngOnInit(): void {
    this.service.getCastById(1).subscribe(data => {
      this.cast = data;
    })
  }

  from() {
    this.service.getCastById(this.from_id).subscribe(data => {
      console.log(data);
      this.cast = data;
      this.cast.id = undefined;
    })
  }

  delete() {
    this.service.deleteCast(this.delete_id).subscribe(data => {
      console.log(data);
    })
  }

  modify() {
    this.cast.id = this.modify_id;
    this.service.updateCast(this.cast).subscribe(data => {
      console.log(data);
    })
  }

  add() {
    this.service.addCast(this.cast).subscribe(data => {
      console.log(data);
    });
  }

  reset() {
    this.cast = new Cast();
  }

}
