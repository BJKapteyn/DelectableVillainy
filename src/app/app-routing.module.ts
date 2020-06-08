import { NgModule } from '@angular/core';
import { RouterModule, Routes} from '@angular/router';
import {VillainsComponent} from './villains/villains.component';
import {DashboardComponent} from './dashboard/dashboard.component';
import {VillainDetailComponent} from './villain-detail/villain-detail.component';
import {VillainBattleComponent} from './villain-battle/villain-battle.component';
import { AnimationTestComponent } from './animation-test/animation-test.component';
import { StartGameComponent } from './start-game/start-game.component';
import { OptionsComponent } from './options/options.component';

//path is the actual string placed as the URL and component is the component that will be displayed
//when the string is entered. Ex. www.domain.com/villains will display VillainsComponent.
const routes: Routes = [
  //with no URI, direct to dashboard
  {path: '', redirectTo: '/dashboard', pathMatch: 'full'},
  {path: 'startgame', component: StartGameComponent},
  {path: 'options', component: OptionsComponent},
  {path: 'villains', component: VillainsComponent},
  {path: 'dashboard', component: DashboardComponent },
  //:name inserts the name of the villain in the URL ex /detail/BeastWellington
  {path: 'detail/:URI', component: VillainDetailComponent},
  {path: 'animation-test', component: AnimationTestComponent},
  {path: 'villain-battle', component: VillainBattleCompenent}
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
