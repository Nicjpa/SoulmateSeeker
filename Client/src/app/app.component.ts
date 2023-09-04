import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Soulmate Seeker';
  users: any;

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getUsers();
    
  }

  getUsers(): void {
    this.http.get('https://localhost:7143/api/Users')
      .subscribe(response => {
        this.users = response;
        console.log(this.users);
      }, error => {
        console.log(error);
      });
  }
}
