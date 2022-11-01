import { Component } from '@angular/core';
import { CourseModel } from './models/CourseModel';
import { StudentModel } from './models/StudentModel';
import { StudentService } from './services/student.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {

  title:string = "Grader";

  infoShown:boolean = false;

  arr:any = [];
  sa:any = [];

  studentModel:StudentModel = new StudentModel;
  studentFullName:string = "";
  studentHeaderName:string = "No Student Selected";

  constructor(private studentService:StudentService) {}

  ngOnInit() {
    const el = document.getElementById('students');
    this.studentService.getAllStudents().subscribe(data => {
      this.arr = data;
      this.arr.forEach((element: StudentModel) => {
        if (el != null)
          el.innerHTML += `<option value='${element.firstName} ${element.lastName}'></option>`;
      });
    });
  }

  squery() {
    this.studentHeaderName = this.studentFullName;

    let index = 0;
    this.studentService.getStudentCourses(this.studentFullName).subscribe(data => {
      this.arr = data;
      this.sa = []
      this.arr.forEach((element: CourseModel) => {
        this.sa[index++] = element.name;
      });
    });

    this.studentFullName = "";
  }
}
