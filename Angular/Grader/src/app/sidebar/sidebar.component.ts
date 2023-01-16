import { Component, OnInit, OnChanges } from '@angular/core';
import { CourseModel } from '../models/CourseModel';
import { StudentModel } from '../models/StudentModel';
import { CourseService } from '../services/course/course.service';
import { StudentService } from '../services/student/student.service';

@Component({
  selector: 'sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit {

  navItems:any = ['Hi', 'there', 'my', 'name', 'is', 'jacob'];

  arr:any = [];

  sortValue:string = "";

  constructor(private courseService : CourseService, private studentService : StudentService) { }

  ngOnInit(): void {
    this.toCourses();
  }

  ngOnChanges(): void {
    console.log(this.sortValue);
  }

  toStudents() {
    this.studentService.all().subscribe(data => {
      this.arr = data;
      this.navItems = [];
      this.arr.forEach((student : StudentModel) => {
        this.navItems.push(`${student.firstName} ${student.lastName}`);
      })
    })
  }

  toCourses() {
    this.courseService.all().subscribe(data => {
      this.arr = data;
      this.navItems = [];
      this.arr.forEach((course : CourseModel) => {
        this.navItems.push(`${course.name} - ${course.section}`);
      })
    })
  }

  toValue(event : any) {
    switch (event.target.value) {
      case "Students": {this.toStudents(); break;}
      case "Classes": {this.toCourses(); break;}
    }
  }

}
