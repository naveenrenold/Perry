import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SearchComponent } from './Search/search/search.component';
import { MainComponent } from './main/main/main.component';

const routes: Routes = [{path:'search',component:SearchComponent},{path:'',component:MainComponent}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
