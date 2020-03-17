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

  constructor(
    //holds information about the route
    private route: ActivatedRoute,
    private villainService: VillainService,
    //service for interacting with the browser
    private location: Location
  ) { }

  //collects Villain info from Villains.component.html template
  @Input() villain: Villain;

  ngOnInit(): void {
    this.getVillain();
  }

  //snapshot is the static image of route info shortly after component was created
  //paramMap is a dictionary of route parameter values extracted from the URL and URI is the key as per villain.ts
  //
  getVillain(): void {
    const villainName = this.route.snapshot.paramMap.get('URI');
    this.villainService.getVillain(villainName).subscribe(villain => this.villain = villain);
  }
}
