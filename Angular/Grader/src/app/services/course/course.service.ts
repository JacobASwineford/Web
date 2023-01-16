import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { CourseModel } from 'src/app/models/CourseModel';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

  private APIUrl:string = environment.APIUrl + environment.APIRoutes.course;

  constructor(private client:HttpClient) { }

  all() : Observable<CourseModel> {
    return this.client.get(this.APIUrl + environment.APISubRoutes.all);
  }

  get(id : number) : Observable<CourseModel> {
    return this.client.get(this.APIUrl + environment.APISubRoutes.get + `/${id}`);
  }

  post(model : CourseModel) : Observable<CourseModel> {
    return this.client.post(this.APIUrl + environment.APISubRoutes.post, model);
  }

  put(model : CourseModel) : Observable<CourseModel> {
    return this.client.put(this.APIUrl + environment.APISubRoutes.put, model);
  }

  delete(id : number) : Observable<CourseModel> {
    return this.client.delete(this.APIUrl + environment.APISubRoutes.delete + `/${id}`);
  }

}
