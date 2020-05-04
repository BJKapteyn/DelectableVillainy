import { Component, OnInit, Input, SimpleChanges } from '@angular/core';
import {Villain} from '../villain';
import {VillainService} from '../villain.service';

@Component({
  selector: 'app-villain-blowup-view',
  templateUrl: './villain-blowup-view.component.html',
  styleUrls: ['./villain-blowup-view.component.css']
})
export class VillainBlowupViewComponent implements OnInit {

  @Input() villainBlowup: Villain;

  isLoaded: boolean = false;

  constructor(
    private villainService: VillainService
  ) { }

  ngOnInit(): void {
  }

  //whenever there is a change in the @Input() properties, reasign the class to reset the animation
  //TODO: figure out how to get the animation to replay
  ngOnChanges() {
    debugger;
    if(this.isLoaded){
      let element = document.getElementById('titleCardText');
      let parent = document.getElementById('infoContainer');
      let newElement = document.createElement('h2');
      newElement.setAttribute('id', 'titleCardText');
      newElement.innerText = this.villainBlowup.name;
      newElement.style.animationName = "titleCard";
      newElement.style.animationDuration = "2s";
      newElement.style.animationFillMode = "forward";
      newElement.style.animationTimingFunction = "cubic-bezier()";
      parent.appendChild(newElement);
      parent.removeChild(element);
      document.getElementById('titleCardText').className = "titleCard";
    } else {
      this.isLoaded = true;
    }
  }




}
