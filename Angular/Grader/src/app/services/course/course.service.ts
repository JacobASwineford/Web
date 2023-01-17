import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { CourseModel } from 'src/app/models/CourseModel';
import { GenericService } from '../generic.service';

@Injectable({
  providedIn: 'root'
})
export class CourseService extends GenericService<CourseModel> {

  constructor(client : HttpClient) {
    super(environment.APIUrl + environment.APIRoutes.course, client);
  }

  all() : Observable<CourseModel> {
    return this.client.get(this.APIUrl + environment.APISubRoutes.all);
  } 
}
