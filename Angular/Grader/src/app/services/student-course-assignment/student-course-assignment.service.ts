import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { StudentCourseAssignmentModel } from 'src/app/models/StudentCourseAssignmentModel';
import { environment } from 'src/environments/environment';
import { GenericService } from '../generic.service';

@Injectable({
  providedIn: 'root'
})
export class StudentCourseAssignmentService extends GenericService<StudentCourseAssignmentModel> {

  constructor(client : HttpClient) {
    super(environment.APIUrl + environment.APIRoutes.studentCourseAssignment, client);
   }
}
