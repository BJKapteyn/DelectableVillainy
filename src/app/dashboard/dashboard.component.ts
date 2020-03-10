import { Component, OnInit } from '@angular/core';
import {Villain} from '../villain';
import {VillainService} from '../villain.service';
import {MessageService} from '../message.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  constructor(private villainService: VillainService, public messageService: MessageService) { }

  villains: Villain[];

  //grab the top 5 villians based off id, in the future it will be based off of a stat

  ngOnInit(): void {
    this.getTopVillains();
  }

  getTopVillains(): void {
    try {
      this.villainService.getVillains()
                         .subscribe(topVillains => this.villains = topVillains.sort(villain => villain.id)
                                                                              .slice(1, 6));
    }
    catch(e) {
      this.messageService.add("Could not retrieve top villains. (dashboard.component.ts)");
      console.log(e);
    }

  }
}
