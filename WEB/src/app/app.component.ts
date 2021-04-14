import { Component } from '@angular/core';
import {HttpClient, HttpClientModule} from '@angular/common/http'


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  readonly ROOTUR ='https://localhost:44365';
  posts:any;
  constructor(private http:HttpClient) {

  }
  getPost(){   
    this.http.get(this.ROOTUR+'/api/Employee').subscribe(Response=>{
      console.log(Response);
      this.posts=Response;
    },error=>{
      console.log(error);
    });
  }
}
