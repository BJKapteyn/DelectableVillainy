import { Component, OnInit } from '@angular/core';
import {IVillain} from '../villain';
import {VillainService} from '../villain.service';

@Component({
  selector: 'StartPage',
  templateUrl: './start-game.component.html',
  styleUrls: ['./start-game.component.scss']
})
export class StartGameComponent implements OnInit {

  constructor(
    public villainService: VillainService
  ) { }

  ngOnInit(): void {
  }

}
