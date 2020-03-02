import { Component, OnInit } from '@angular/core';
import {Villian} from '../villian'

@Component({
  selector: 'app-villians',
  templateUrl: './villians.component.html',
  styleUrls: ['./villians.component.css']
})
export class VilliansComponent implements OnInit {

  constructor() { }

  villian: Villian = {
    id: 1,
    name: 'SeuJorgio'
  }

  ngOnInit(): void {
  }

}

