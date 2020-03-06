import { Component, OnInit } from '@angular/core';

import {Villian} from '../villian';
import {VillianService} from '../villian.service';
import {MessageService} from '../message.service';

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

  onSelect(villian: Villian) {
    this.selectedVillian = villian;
    this.messageService.add(`HeroService: Selected ${villian.name}`);
  }

  ngOnInit(): void {
    this.getVillians();
  }

}

