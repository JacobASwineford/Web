import { Component, OnInit } from '@angular/core';
import { Input } from '@angular/core'

@Component({
  selector: 'app-subject-info',
  templateUrl: './subject-info.component.html',
  styleUrls: ['./subject-info.component.css']
})
export class SubjectInfoComponent implements OnInit {

  @Input() subject:string = '';
  @Input() section:string = '';

  constructor() { }

  ngOnInit(): void {
  }

  ngOnChanges(): void {
    console.log(`changed: subject = ${this.subject}`);
  }

  shown:boolean = false;
  show() {
    const el = document.getElementById(`info-${this.subject}`);
    if (this.shown && el != null) {
      el.style.display = "none";
      this.shown = false;
    } else if (el != null) {
      el.style.display = "flex";
      this.shown = true;
    }
  }

}
