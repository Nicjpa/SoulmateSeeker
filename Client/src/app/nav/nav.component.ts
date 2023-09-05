import { Component, OnInit } from '@angular/core';
import { AccountService } from '../_services/account.service';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};
  username: string;

  constructor(
    private accountService: AccountService, 
    private router: Router, 
    private toastr: ToastrService) { }

  ngOnInit(): void {
    this.accountService.currentUser$.subscribe(user => {
      if(user) this.username = user.username;
    })
  }

  login() {
    this.accountService.login(this.model).subscribe(response => { 
      this.router.navigateByUrl("/members");
    }, error => {
      console.log(error.error.errors);
      const errorMessage = !!error?.error?.errors ? "Username or password cannot be empty" : error.error; 
      this.toastr.error(errorMessage);
    });
  }

  logout() {
    this.accountService.logout(); 
    this.model = {}; 
    this.username = null;
    this.router.navigateByUrl("/");
  }
}
