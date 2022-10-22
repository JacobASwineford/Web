import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { StudentModel } from '../models/StudentModel';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private client:HttpClient) { }

  getAllStudents(): Observable<StudentModel> {
    return this.client.get('https://localhost:7285/student/get');
  }
}
