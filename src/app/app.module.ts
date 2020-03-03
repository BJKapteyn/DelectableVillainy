import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { VilliansComponent } from './villians/villians.component';

import { FormsModule } from '@angular/forms';
import { VillianDetailComponent } from './villian-detail/villian-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    VilliansComponent,
    VillianDetailComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
