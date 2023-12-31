import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Pagination } from '../shared/models/Paging';
import { Product } from '../shared/models/Product';
import { Brand } from '../shared/models/brands';
import { Type } from '../shared/models/Types';
import { ShopParams } from '../shared/models/shopParams';

@Injectable({
  providedIn: 'root'
})
export class ShopService {

  constructor(private http:HttpClient) { }
baseUrl  = "https://localhost:44327/api/"
  getProducts(shopParams:ShopParams){
    let params = new HttpParams();
    if(shopParams.brandId > 0) params = params.append("brandId",shopParams.brandId);
    if(shopParams.typeId > 0) params = params.append("typeId",shopParams.typeId);
    if(shopParams.search) params = params.append("search",shopParams.search);
     params = params.append("Sort",shopParams.sort);
     params = params.append("pageIndex",shopParams.pageNumber);
     params = params.append("pageSize",shopParams.pageSize);

    return this.http.get<Pagination<Product[]>>(`${this.baseUrl}Product`,{params:params});
  }

  getBrands(){
    return this.http.get<Brand[]>(`${this.baseUrl}Product/brands`);
  }

  getTypes(){
    return this.http.get<Type[]>(`${this.baseUrl}Product/types`);
  }

  getProduct(id:number){
    return this.http.get<Product>(`${this.baseUrl}Product/${id}`);
  }
}
