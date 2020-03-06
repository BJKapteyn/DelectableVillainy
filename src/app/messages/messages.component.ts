import { Component, OnInit } from '@angular/core';
import {MessageService} from '../message.service';

@Component({
  selector: 'app-messages',
  templateUrl: './messages.component.html',
  styleUrls: ['./messages.component.css']
})
export class MessagesComponent implements OnInit {


  constructor(public messageService: MessageService) { }


  static fade(fadeTime: number): NodeJS.Timeout[] {
    let messageView = document.getElementById('messageView');

    messageView.className = 'message';
    messageView.style.display = "block";

    let timeout1 = setTimeout(() => {
      messageView.className = 'messageNone';
    }, fadeTime);

    let timeout2 = setTimeout(() => {
      messageView.style.display = "none";
    }, fadeTime + 2000);

    let timeouts = [timeout1, timeout2];
    return timeouts;
  }

  ngOnInit(): void {
  }

}
