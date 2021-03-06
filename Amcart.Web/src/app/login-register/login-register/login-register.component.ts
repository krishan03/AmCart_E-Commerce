import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login-register',
  templateUrl: './login-register.component.html',
  styleUrls: ['./login-register.component.css']
})
export class LoginRegisterComponent implements OnInit {
  loginForm: FormGroup;
  constructor(private router: Router) {
    this.loginForm = new FormGroup({
      userName: new FormControl(''),
      password: new FormControl(''),
    });
  }

  ngOnInit() {

  }

  onSubmit = () => {
  }

}
