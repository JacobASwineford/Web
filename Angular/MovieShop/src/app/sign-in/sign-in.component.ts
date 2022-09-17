import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { Signin } from '../models/Signin';
import { AccountService } from '../services/account/account.service';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent implements OnInit {

  signin_form = this.fb.group({
    email: ['', Validators.required],
    password: ['', Validators.required]
  })

  sub:Signin = new Signin();

  constructor(private fb:FormBuilder,
    private service:AccountService) { }

  ngOnInit(): void {
  }

  submit() {
    console.log(this.signin_form.value);
    this.from_form();
    console.log(this.sub);
    this.service.signIn(this.sub).subscribe(data => {
      console.log(data);
    })
  }

  from_form() {
    this.sub.userName = this.signin_form.value.email!;
    this.sub.password = this.signin_form.value.password!;
  }

}
