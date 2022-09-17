import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class GenreService {

  constructor(private client:HttpClient) { }

  getAllGenres() {
    return this.client.get(`https://localhost:7159/genre/get`);
  }
}
