import { Component, OnInit } from '@angular/core';
import {IVillain} from '../villain';
import {VillainService} from '../villain.service';
import {MessageService} from '../message.service';

//define aspects of the compenent
@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  constructor(private villainService: VillainService, public messageService: MessageService) { }

  villains: IVillain[];

  //grab the top 5 villians based off id, in the future it will be based off of a stat

  ngOnInit(): void {
    this.getTopVillains();
  }

  getTopVillains(): void {
    try {
      this.villainService.getVillains()
                         .subscribe(topVillains => this.villains = topVillains.sort(villain => villain.Id)
                                                                              .slice(1, 6));
    }
    catch(e) {
      this.messageService.add("Could not retrieve top villains. (dashboard.component.ts)");
      console.log(e);
    }

  }
}
