import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Signup } from '../models/Signup';
import { AccountService } from '../services/account/account.service';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  signup_form = this.fb.group({
    first_name: ['', Validators.required],
    last_name: ['', Validators.required],
    email: ['', Validators.required],
    password: ['', Validators.required],
    confirm_password: ['', Validators.required]
  })

  sub:Signup = new Signup();

  constructor(private fb: FormBuilder,
    private service:AccountService) {
  }

  ngOnInit(): void {
  }

  submit() {
    console.log(this.signup_form.value);
    this.from_form();
    this.service.signUp(this.sub).subscribe(data => {
      console.log(data);
    })
  }

  from_form() {
    this.sub.firstName = this.signup_form.value.first_name!;
    this.sub.lastName = this.signup_form.value.last_name!;
    this.sub.email = this.signup_form.value.email!;
    this.sub.password = this.signup_form.value.password!;
    this.sub.confirmPassword = this.signup_form.value.confirm_password!;
    console.log(this.sub);
  }

}
