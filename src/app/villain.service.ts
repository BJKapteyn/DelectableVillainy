import { Injectable } from '@angular/core';
import {Villain} from './villain';
import {VILLAINS} from './mock-villains';
import {Observable, of} from 'rxjs';
import {MessageService} from './message.service';

@Injectable({
  providedIn: 'root'
})
export class VillainService {

  getVillains(): Observable<Villain[]> {
    return of(VILLAINS);
  }

  constructor(public messageService: MessageService) { }
}
