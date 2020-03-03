import { Component, OnInit } from '@angular/core';
import {Villian} from '../villian';

@Component({
  selector: 'app-villian-detail',
  templateUrl: './villian-detail.component.html',
  styleUrls: ['./villian-detail.component.css']
})
export class VillianDetailComponent implements OnInit {

  constructor() { }

  villian: Villian;

  onSelect(villian: Villian) {
    this.villian = villian;
  }

  ngOnInit(): void {
  }

}
