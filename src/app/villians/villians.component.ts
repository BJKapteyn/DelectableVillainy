import { Component, OnInit } from '@angular/core';
import {Villian} from '../villian';
import {VILLIANS} from '../mock-villians';

@Component({
  selector: 'app-villians',
  templateUrl: './villians.component.html',
  styleUrls: ['./villians.component.css']
})
export class VilliansComponent implements OnInit {

  constructor() { }

  villians = VILLIANS;

  ngOnInit(): void {
  }

}

