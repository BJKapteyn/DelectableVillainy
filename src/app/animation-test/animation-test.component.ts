import { Component, OnInit } from '@angular/core';
import {IVillain, Villain} from '../villain';
import {VillainService} from '../villain.service';
import {iAnimation} from '../iAnimation';
import {
  trigger,
  state,
  style,
  animate,
  transition,
  // ...
} from '@angular/animations';
@Component({
  selector: 'app-animation-test',
  templateUrl: './animation-test.component.html',
  styleUrls: ['./animation-test.component.css'],
  animations: [
    trigger('swingSword', [
      state('topSwing', style({
        transform: 'rotate(270deg)',
        transformOrigin: 'bottom left'
        }),
      ),
      state('bottomSwing', style({
        transform: 'rotate(360deg)',
        transformOrigin: 'bottom left'
      })),
      transition('topSwing => bottomSwing', animate(500)),
      transition('bottomSwing => topSwing', animate(0))
    ])
  ]
})
export class AnimationTestComponent implements OnInit {

  villains: Villain[];

  animateSword: iAnimation;

  constructor(
    private villainService: VillainService
  ) { }

  ngOnInit(): void {
    this.villainService.getVillains().subscribe((data: Villain[]) => this.villains = data);
    this.animateSword = new iAnimation();
  }

  animate(animation: iAnimation): void {
    debugger;
    animation.State = false;
    setTimeout(function() {
      animation.State = true;
    }, 2000)
  }

}
