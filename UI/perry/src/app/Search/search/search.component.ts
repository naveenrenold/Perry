import { HttpClient } from '@angular/common/http';
import { Component, Injectable, OnInit } from '@angular/core';

class a{
id:string='';
description:string=''

}
@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
@Injectable()
export class SearchComponent implements OnInit {
  path:string='';

  data:a[]=[];
ngOnInit(): void {
}
constructor(private http:HttpClient)
{

}
APICall()
{
console.log('Api call!')
this.path='http://localhost:5229/api/Command';
this.http.get(this.path).subscribe(res=>{
this.data=res as a[];
})
}
}
