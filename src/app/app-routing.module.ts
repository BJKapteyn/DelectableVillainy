import { NgModule } from '@angular/core';
import { RouterModule, Routes} from '@angular/router';
import {VillainsComponent} from './villains/villains.component';

const routes: Routes = [
  {path: 'villains', component: VillainsComponent}
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
