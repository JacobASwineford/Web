import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AssignmentModel } from 'src/app/models/AssignmentModel';
import { environment } from 'src/environments/environment';
import { GenericService } from '../generic.service';

@Injectable({
  providedIn: 'root'
})
export class AssignmentService extends GenericService<AssignmentModel> {

  constructor(client : HttpClient) {
    super(environment.APIUrl + environment.APIRoutes.assignment, client);
  }
  
}
