import { Component, OnInit } from '@angular/core';

import {Villian} from '../villian';
import {VillianService} from '../villian.service';
import {MessageService} from '../message.service';
import {MessagesComponent} from '../messages/messages.component';

@Component({
  selector: 'app-villians',
  templateUrl: './villians.component.html',
  styleUrls: ['./villians.component.css']
})
export class VilliansComponent implements OnInit {

  constructor(private villianService: VillianService, private messageService: MessageService) { }

  villians: Villian[];
  selectedVillian: Villian;

  getVillians(): void {
    this.villianService.getVillians().subscribe(villians => this.villians = villians);
  }

  //store timeout to be cleared if user clicks another villian
  timeouts: NodeJS.Timeout[];
  fadeMessage(): void {
    this.timeouts = MessagesComponent.fade(2000);
  }

  //show messages briefly
  onSelect(villian: Villian) {

    if(this.timeouts) {
      this.timeouts.forEach(timeout => clearTimeout(timeout))
    }
    //wont add to the list if already selected
    if(this.selectedVillian !== villian)
    {
      this.messageService.add(`HeroService: Selected ${villian.name}`);

    }
    this.selectedVillian = villian;
    this.fadeMessage();
  }

  ngOnInit(): void {
    this.getVillians();
  }

}

