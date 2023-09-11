import { Component } from '@angular/core';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent {
  a:string;
constructor()
{
  this.a='http://localhost:4200/search';
}
}
