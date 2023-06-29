import { HttpClient } from '@angular/common/http';
import { Component, Injectable, OnInit } from '@angular/core';


@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
@Injectable()
export class SearchComponent implements OnInit {
  path='';
  data={};
ngOnInit(): void {

}
constructor(private http: HttpClient)
{

}
APICall()
{
this.path='';
this.http.get(this.path).subscribe(res=>{
this.data=res;
})
}
}
