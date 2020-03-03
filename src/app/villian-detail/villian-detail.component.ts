import { Component, OnInit, Input } from '@angular/core';
import {Villian} from '../villian';

@Component({
  selector: 'app-villian-detail',
  templateUrl: './villian-detail.component.html',
  styleUrls: ['./villian-detail.component.css']
})
export class VillianDetailComponent implements OnInit {

  constructor() { }
  //collects villian info from villians.component.html template
  @Input() villian: Villian;

  ngOnInit(): void {
  }

}
