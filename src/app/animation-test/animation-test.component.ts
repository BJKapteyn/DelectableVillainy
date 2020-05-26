import { Component, OnInit } from '@angular/core';
import {IVillain, Villain} from '../villain';
import {VillainService} from '../villain.service';

@Component({
  selector: 'app-animation-test',
  templateUrl: './animation-test.component.html',
  styleUrls: ['./animation-test.component.css']
})
export class AnimationTestComponent implements OnInit {

  villains: Villain[];

  constructor(
    private villainService: VillainService
  ) { }

  ngOnInit(): void {
    debugger;
    this.villainService.getVillains().subscribe((data: Villain[]) => this.villains = data);
  }

}
