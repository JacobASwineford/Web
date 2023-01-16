import { Component } from '@angular/core';
import { CourseModel } from './models/CourseModel';
import { StudentModel } from './models/StudentModel';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {

  title = "Grader";

  students:StudentModel[] = [];
  arr:any = [];

  sa:any = [];
  seca:any = [];

  studentModel:StudentModel = new StudentModel;
  studentFullName:string = "";
  studentHeaderName:string = "No Student Selected";

  constructor() {}

  ngOnInit() {
    const el = document.getElementById('students');
    // this.studentService.getAllStudents().subscribe(data => {

    //   this.arr = data;
    //   let i = 0;
    //   this.arr.forEach((student: StudentModel) => {
    //       if (el == null) return;
    //       this.students[i++] = student;
    //       el.innerHTML = `<option value='${student.firstName} ${student.lastName} [${student.id}]'>`;
    //   });

    //   this.arr = [];
    // });
  }

  squery() {
    this.studentHeaderName = this.studentFullName;

    let index = 0;
    // this.studentService.getStudentCourses(this.studentFullName).subscribe(data => {
    //   this.arr = data;
    //   this.sa = []
    //   this.arr.forEach((element: CourseModel) => {
    //     this.sa[index] = element.name;
    //     this.seca[index++] = element.section;
    //   });
    // });

    this.studentFullName = "";
  }
}
