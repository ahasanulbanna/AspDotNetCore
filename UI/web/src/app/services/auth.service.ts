import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import {map} from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
baseUrl='https://localhost:44365/api/Auth/';
constructor(private http:HttpClient) { }
login(model:any){
  return this.http.post(this.baseUrl+'login', model)
  .pipe(
    map((Response:any)=>{
      const user=Response;
      if(user){
        localStorage.setItem('token', user.token);
      }
    })
  );
}

}
