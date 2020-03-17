import { Component, OnInit, Input } from '@angular/core';
import {Villain} from '../villain';
import {VillainService} from '../villain.service';

@Component({
  selector: 'app-villain-blowup-view',
  templateUrl: './villain-blowup-view.component.html',
  styleUrls: ['./villain-blowup-view.component.css']
})
export class VillainBlowupViewComponent implements OnInit {

  constructor(
    villain: Villain,
    villainService: VillainService
  ) { }

  ngOnInit(): void {
  }

  @Input() villain: Villain;
}
