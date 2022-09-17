import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CreateUserService {

  token:any;

  constructor(private client: HttpClient) { }

  getPurchasedMovies():any {
    this.client.get("something").subscribe(data => {
      this.token = data;
    })
    return this.token;
  }

  getFavoritedMovies():any {
    this.client.get("something").subscribe(data => {
      this.token = data;
    })
    return this.token;
  }


}
