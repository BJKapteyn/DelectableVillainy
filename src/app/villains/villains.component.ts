import { Component, OnInit } from '@angular/core';
import {IVillain} from '../villain';
import {VillainService} from '../villain.service';
import {MessageService} from '../message.service';
import {MessagesComponent} from '../messages/messages.component';
import {VillainBlowupViewComponent} from '../villain-blowup-view/villain-blowup-view.component';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-villains',
  templateUrl: './villains.component.html',
  styleUrls: ['./villains.component.css']
})

export class VillainsComponent implements OnInit {

  constructor(
    private villainService: VillainService,
    private messageService: MessageService
    ) { }

  villains: IVillain[];
  selectedVillain: IVillain;

  //pulls villain list asynchronously
  getVillains(): void {
    this.villainService.getVillains().subscribe(villains => this.villains = villains);
  }

  getVillain(villainName: string) {

  }

  onSelect(villain: IVillain) {
    if(this.selectedVillain != villain) {
      this.messageService.add(`HeroService: Selected ${villain.name}`);
    }
    this.selectedVillain = villain;
    //adds fade in and out effect on messages. if you change the timing here, change it in the messagesNone rule set
    //in messages.component.css as well. Ex. .fade(3000) requires animation-duration of 3s in messagesNone.
    MessagesComponent.fade(2000);
  }

  ngOnInit(): void {
    this.getVillains();
  }

}

