import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Cast } from 'src/app/models/Cast';

@Injectable({
  providedIn: 'root'
})
export class CastService {

  constructor(private client: HttpClient) { }

  getCastDetails(movieId:number): Observable<any> {
    return this.client.get(`https://localhost:7159/cast/details/${movieId}`);
  }

  getCastById(id:number):Observable<Cast> {
    return this.client.get(`https://localhost:7159/cast/get/${id}`);
  }

  addCast(cast:Cast):Observable<Cast> {
    return this.client.post("https://localhost:7159/cast/post", cast);
  }

  updateCast(cast:Cast):Observable<Cast> {
    return this.client.put("https://localhost:7159/cast/update", cast);
  }

  deleteCast(id:number) {
    return this.client.delete(`https://localhost:7159/cast/delete/${id}`);
  }
}
