import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Genre } from 'src/app/models/Genre';
import { Movie } from 'src/app/models/Movie';

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  constructor(private client: HttpClient) { }

  getAllMovies():Observable<any> {
    return this.client.get("https://localhost:7159/movies/get");
  }

  getMovieById(id:number):Observable<Movie> {
    return this.client.get(`https://localhost:7159/movies/get/${id}`);
  }

  getMovieByTitle(title:string):Observable<Movie> {
    return this.client.get(`https://localhost:7159/movies/getT/${title}`)
  }

  getGenresByMovie(id:number):Observable<Genre> {
    console.log(`https://localhost:7159/movies/genre/${id}`);
    return this.client.get(`https://localhost:7159/movies/genre/${id}`);
  }

  getMoviesByGenreName(genreName:string) {
    return this.client.get(``);
  }

  addMovie(movie:Movie) {
    console.log(movie);
    return this.client.post("https://localhost:7159/movies/post", movie);
  }

  updateMovie(movie:Movie) {
    console.log(movie);
    return this.client.post("https://localhost:7159/movies/update", movie);
  }

  deleteMovie(id:number) {
    return this.client.delete(`https://localhost:7159/movies/delete/${id}`);
  }
}
