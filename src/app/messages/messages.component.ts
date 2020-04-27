import { Component, OnInit } from '@angular/core';
import {MessageService} from '../message.service';

@Component({
  selector: 'app-messages',
  templateUrl: './messages.component.html',
  styleUrls: ['./messages.component.css']
})
export class MessagesComponent implements OnInit {

  constructor(public messageService: MessageService) { }

  static timeouts: NodeJS.Timeout[];

  public static fade(fadeTime: number): void {
    let messageView = document.getElementById('messageView');

    if(this.timeouts) {
      this.timeouts.forEach(x => clearTimeout(x));
    }

    messageView.className = 'message';
    messageView.style.display = "block";

    let timeout1 = setTimeout(() => {
      messageView.className = 'messageNone';
    }, fadeTime);
    //set display
    let timeout2 = setTimeout(() => {
      messageView.style.display = "none";
    }, fadeTime + 2000);

    this.timeouts = [timeout1, timeout2];
  }

  ngOnInit(): void {
  }

}
