import { HttpClient } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  username !: string;
  password !: string;
  _HttpClient = inject(HttpClient)


  onlogin(){
    console.log(this.username)
    console.log(this.password)
    this._HttpClient.post('http://localhost:5066/api/User/Login',{
      username: this.username,
      password: this.password}).subscribe({
      next: (response) => {
        alert("Login Successful");
  }
})
  }}