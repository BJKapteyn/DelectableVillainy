import { Component, OnInit } from '@angular/core';

import {Villain} from '../villain';
import {VillainService} from '../villain.service';
import {MessageService} from '../message.service';
import {MessagesComponent} from '../messages/messages.component';

@Component({
  selector: 'app-villains',
  templateUrl: './villains.component.html',
  styleUrls: ['./villains.component.css']
})

export class VillainsComponent implements OnInit {

  constructor(private villainService: VillainService, private messageService: MessageService) { }

  villains: Villain[];
  selectedVillain: Villain;

  getVillains(): void {
    this.villainService.getVillains().subscribe(villains => this.villains = villains);
  }

  onSelect(villain: Villain) {
    if(this.selectedVillain != villain) {
      this.messageService.add(`HeroService: Selected ${villain.name}`);
    }
    this.selectedVillain = villain;
    MessagesComponent.fade(2000);
  }

  ngOnInit(): void {
    this.getVillains();
  }

}

