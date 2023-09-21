import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Product } from './models/Product';
import { Pagination } from './models/Paging';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'Store Application';
 
  constructor(private http:HttpClient) {}
prodcts:Product[]=[];
  ngOnInit(): void {
    this.http.get<Pagination<Product[]>>("https://localhost:44327/api/Product?pageSize=50").subscribe({
      next:response=>this.prodcts = response.data,
      error:error=>console.log(error),
      complete:()=>{
        console.log("request complated")
        console.log("extra staments")
      }
    })
    }
}
