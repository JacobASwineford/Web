import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { StudentModel } from 'src/app/models/StudentModel';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  private APIUrl : string = environment.APIUrl + environment.APIRoutes.student;

  constructor(private client : HttpClient) { }

  all() : Observable<StudentModel> {
    return this.client.get(this.APIUrl + environment.APISubRoutes.all);
  }

  get(id : number) : Observable<StudentModel> {
    return this.client.get(this.APIUrl + environment.APISubRoutes.get + `/${id}`);
  }

  post(model : StudentModel) : Observable<StudentModel> {
    return this.client.post(this.APIUrl + environment.APISubRoutes.post, model);
  }
   
  put(model : StudentModel) : Observable<StudentModel> {
    return this.client.put(this.APIUrl + environment.APISubRoutes.put, model);
  }

  delete(id : number) : Observable<StudentModel> {
    return this.client.delete(this.APIUrl + environment.APISubRoutes.delete + `/${id}`);
  }
}
