import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { StudentModel } from 'src/app/models/StudentModel';
import { environment } from 'src/environments/environment';
import { GenericService } from '../generic.service';

@Injectable({
  providedIn: 'root'
})
export class StudentService extends GenericService<StudentModel> {

  constructor(client : HttpClient) {
     super(environment.APIUrl + environment.APIRoutes.student, client); 
  }

  all() : Observable<StudentModel> {
    return this.client.get(this.APIUrl + environment.APISubRoutes.all);
  }
}
