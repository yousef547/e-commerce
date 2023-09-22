import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { ShopService } from '../shop.service';
import { Product } from 'src/app/shared/models/Product';
import { Brand } from 'src/app/shared/models/brands';
import { Type } from 'src/app/shared/models/Types';
import { ShopParams } from 'src/app/shared/models/shopParams';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.scss']
})
export class ShopComponent implements OnInit {
  @ViewChild('search')searchTerms?:ElementRef;
products:Product[]=[];
brands:Brand[]=[];
types:Type[]=[];
shopParams = new ShopParams();
totalCount=0;
sortOptions=[
  {name:'Alphabetical',value:'name'},
  {name:'Price : low to high',value:'ProceAsc'},
  {name:'Price : High to Low',value:'PriceDesc'},

]
constructor(private shop:ShopService) {
  }
  ngOnInit(): void {
    this.getProduct();
    this.getBrands();
    this.getType();
  }
  getProduct(){
    this.shop.getProducts(this.shopParams).subscribe({
      next:response=>{
        this.products=response.data;
        this.shopParams.pageNumber=response.pageIndex;
        this.shopParams.pageSize = response.pageSize;
        this.totalCount=response.count
      },
      error:error=>console.log(error)
    })
  }

  getBrands(){
    this.shop.getBrands().subscribe({
      next:response=>this.brands=[{id:0,name:'All'},...response],
      error:error=>console.log(error)
    })
  }

  getType(){
    this.shop.getTypes().subscribe({
      next:response=>this.types=[{id:0,name:'All'},...response],
      error:error=>console.log(error)
    })
  }

  onBrandSelected(brandId:number){
    this.shopParams.brandId = brandId;
    this.shopParams.pageNumber = 1;
    this.getProduct();
  }

  onTypeSelected(typeId:number){
    this.shopParams.typeId = typeId;
    this.shopParams.pageNumber = 1;
    this.getProduct();
  }
  onSortSelected(event:any){
    this.shopParams.sort=event.target.value;

    this.getProduct();

  }
  onPageChange(event:any){
    if(this.shopParams.pageNumber !== event.page){
      this.shopParams.pageNumber=event.page;
      this.getProduct();
    }
  }

  onSearch(){
    this.shopParams.search = this.searchTerms?.nativeElement.value;
    this.shopParams.pageNumber = 1;
    this.getProduct();
    
  }
  onReast(){
    if(this.searchTerms)this.searchTerms.nativeElement.value = "";
    this.shopParams = new ShopParams();
    this.getProduct();
  }

}
