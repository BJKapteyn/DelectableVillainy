import { Component, OnInit } from '@angular/core';
import {VillainService} from '../villain.service';
import {Villain, IVillain} from '../villain';

@Component({
  selector: 'app-villain-battle',
  templateUrl: './villain-battle.component.html',
  styleUrls: ['./villain-battle.component.css']
})
export class VillainBattleComponent implements OnInit {

  constructor(villainService: VillainService) { }

  ngOnInit(): void {
  }

  yourVillain: Villain;
  opponentVillain: Villain;

}
