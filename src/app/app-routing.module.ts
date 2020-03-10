import { NgModule } from '@angular/core';
import { RouterModule, Routes} from '@angular/router';
import {VillainsComponent} from './villains/villains.component';

//path is the actual string placed as the URL and component is the component that will be displayed
//when the string is entered. Ex. www.domain.com/villains will display VillainsComponent.
const routes: Routes = [
  {path: 'villains', component: VillainsComponent}
];

@NgModule({

  //adds the RouterModule to the AppRoutingModule and configures the delclared routes in one step
  imports: [
    RouterModule.forRoot(routes)
  ],
  //allows the use of RouterModule throughout the app
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
