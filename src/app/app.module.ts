import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from "@angular/common/http";
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { VillainsComponent } from './villains/villains.component';

import { FormsModule } from '@angular/forms';
import { VillainDetailComponent } from './villain-detail/villain-detail.component';
import { MessagesComponent } from './messages/messages.component';
import { AppRoutingModule } from './app-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { VillainBlowupViewComponent } from './villain-blowup-view/villain-blowup-view.component';
import { BackendTestComponent } from './backend-test/backend-test.component';
import { AnimationTestComponent } from './animation-test/animation-test.component';
import { StartGameComponent } from './start-game/start-game.component';
import { OptionsComponent } from './options/options.component';
import { VillainBattleComponent } from './villain-battle/villain-battle.component';

@NgModule({
  declarations: [
    AppComponent,
    VillainsComponent,
    VillainDetailComponent,
    MessagesComponent,
    DashboardComponent,
    VillainBlowupViewComponent,
    BackendTestComponent,
    AnimationTestComponent,
    StartGameComponent,
    OptionsComponent,
    VillainBattleComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    //HttpClientModule needs to be after BrowserModule.
    HttpClientModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent],
  exports: []
})
export class AppModule { }
