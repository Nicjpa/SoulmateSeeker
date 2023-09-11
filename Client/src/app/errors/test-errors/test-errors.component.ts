import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-test-errors',
  templateUrl: './test-errors.component.html',
  styleUrls: ['./test-errors.component.css']
})
export class TestErrorsComponent {
  baseUrl: string = environment.apiUrl;
  validationErrors: string[] = [];

  constructor(private http: HttpClient) {}

  get404Error() {
    this.http.get(this.baseUrl + "buggy/not-found").subscribe(response => {
      console.log(response);
    }, error => {
      console.log(error);
    });
  }

  get400Error() {
    this.http.get(this.baseUrl + "buggy/bad-request").subscribe(response => {
      console.log(response);
    }, error => {
      console.log(error);
    });
  }

  get500Error() {
    this.http.get(this.baseUrl + "buggy/server-error").subscribe(response => {
      console.log(response, "OK");
    }, error => {
      console.log(error, "ERROR");
    });
  }

  get401Error() {
    this.http.get(this.baseUrl + "buggy/auth").subscribe(response => {
      console.log(response);
    }, error => {
      console.log(error);
    });
  }

  get400ValidationError() {
    this.http.post(this.baseUrl + "account/register", {username: "", password: "as"}).subscribe(response => {
      console.log(response);
    }, error => {
      this.validationErrors = error;
      console.log(error);
    });
  }
 
}
