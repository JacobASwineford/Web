import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ScoreModel } from 'src/app/models/ScoreModel';
import { environment } from 'src/environments/environment';
import { GenericService } from '../generic.service';

@Injectable({
  providedIn: 'root'
})
export class ScoreService extends GenericService<ScoreModel> {

  constructor(client : HttpClient) {
    super(environment.APIUrl + environment.APIRoutes.score, client);
   }
}
