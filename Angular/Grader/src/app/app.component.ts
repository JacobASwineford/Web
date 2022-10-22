import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { StudentModel } from './models/StudentModel';
import { StudentService } from './services/student.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {

  title = "Grader";

  arr:any = [];

  studentModel:StudentModel = new StudentModel;
  

  studentFullName:string = "";
  studentForm = new FormGroup({
    firstName: new FormControl(''),
    lastName: new FormControl('')
  })

  constructor(private studentService:StudentService) {}

  ngOnInit() {
    const el = document.getElementById('students');
    this.studentService.getAllStudents().subscribe(data => {
      this.arr = data;
      this.arr.forEach((element: StudentModel) => {
        if (el != null)
    el.innerHTML += `<option value='${element.firstName} ${element.lastName}'></option>`;
      });
    })
  }

  squery() {
    console.log(this.studentFullName);
    this.studentFullName = "";
  }
}
