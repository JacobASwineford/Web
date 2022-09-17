import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Signin } from 'src/app/models/Signin';
import { Signup } from 'src/app/models/Signup';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  constructor(private client:HttpClient) { }

  signIn(si:Signin):Observable<Signin> {
    return this.client.post("https://localhost:7159/account/login", si);
  }

  signUp(su:Signup):Observable<Signup> {
    return this.client.post("https://localhost:7159/account/signup", su);
  }
}
