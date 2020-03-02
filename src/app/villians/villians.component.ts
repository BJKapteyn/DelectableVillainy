import { Component, OnInit } from '@angular/core';
import {Villian} from '../villian';
import {VILLIANS} from '../mock-villians';
import { HeapProfiler } from 'inspector';

@Component({
  selector: 'app-villians',
  templateUrl: './villians.component.html',
  styleUrls: ['./villians.component.css']
})
export class VilliansComponent implements OnInit {

  constructor() { }

  villians = VILLIANS;
  selectedVillian: Villian;

  onSelect(villian: Villian) {
    this.selectedVillian = villian;
  }

  ngOnInit(): void {
  }

}

