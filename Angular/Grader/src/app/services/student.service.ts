import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { StudentModel } from '../models/StudentModel';
import { CourseModel } from '../models/CourseModel';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private client:HttpClient) { }

  getAllStudents(): Observable<StudentModel> {
    return this.client.get('https://localhost:7285/student/get');
  }

  getStudentCourses(fullname:string): Observable<CourseModel> {
    var arr = fullname.split(" ", 2);
    var f = arr[0];
    var l = arr[1];
    return this.client.get(`https://localhost:7285/student/get/${f}.${l}/courses`);
  }


}
