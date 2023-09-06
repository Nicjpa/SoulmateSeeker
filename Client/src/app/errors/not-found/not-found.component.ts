import { Component, OnInit } from '@angular/core';
import { take } from 'rxjs';
import { AccountService } from 'src/app/_services/account.service';

@Component({
  selector: 'app-not-found',
  templateUrl: './not-found.component.html',
  styleUrls: ['./not-found.component.css']
})
export class NotFoundComponent implements OnInit {
  routerLinkAddress: string;
  constructor(private accountService: AccountService) {}
  
  ngOnInit() {
    this.accountService.getCurrentUser()
      .pipe(take(1))
      .subscribe(user => {
      this.routerLinkAddress = !!user ? "/members" : "/";
    })
  }
}
