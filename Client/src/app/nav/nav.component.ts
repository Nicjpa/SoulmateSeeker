import { Component, OnInit } from '@angular/core';
import { AccountService } from '../_services/account.service';
import { Observable } from 'rxjs';
import { User } from '../_models/user';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};
  username: string;

  constructor(public accountService: AccountService) { }

  ngOnInit(): void {
    this.accountService.currentUser$.subscribe(user => {
      if(user) this.username = user.username.charAt(0).toUpperCase() + user.username.slice(1);;
    })
  }

  login() {
    this.accountService.login(this.model).subscribe(response => { 
    }, error => {
      console.log(error.error);
    });
  }

  logout() {
    this.accountService.logout(); 
    this.model = {}; 
  }
}
