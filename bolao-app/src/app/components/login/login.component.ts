import { Component, OnInit } from '@angular/core';
import { Form, FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  form: any;

  email: string ='fabio@gmail.com';
  password: string='123456';
  message:string = '';

  constructor(private formBuilder: FormBuilder, private router: Router) {
    this.criarForm();
   }


  criarForm(){
    this.form = this.formBuilder.group({
      email: [''],
      password: ['']
    })
  }

  login(){
    if(this.form.get('email').value == this.email && this.form.get('password').value == this.password )
    {
      this.message = "Login feito com sucesso!";
      this.router.navigate(['participant']);
      
    }
    else
    {
      this.message = "E-mail ou senha estão errados!";
    }
  }
}
