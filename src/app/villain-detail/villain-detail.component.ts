import { Component, OnInit, Input } from '@angular/core';
import {ActivatedRoute} from '@angular/router';
import {Location} from "@angular/common";

import {VillainService} from '../villain.service';
import {Villain} from '../villain';

@Component({
  selector: 'app-villain-detail',
  templateUrl: './villain-detail.component.html',
  styleUrls: ['./villain-detail.component.css']
})
export class VillainDetailComponent implements OnInit {

  constructor() { }
  //collects Villain info from Villains.component.html template
  @Input() villain: Villain;

  ngOnInit(): void {
  }

}
