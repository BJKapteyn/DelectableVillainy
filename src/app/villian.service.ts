import { Injectable } from '@angular/core';
import {Villian} from './villian';
import {VILLIANS} from './mock-villians';
import {Observable, of} from 'rxjs';
import {MessageService} from './message.service';

@Injectable({
  providedIn: 'root'
})
export class VillianService {

  getVillians(): Observable<Villian[]> {
    return of(VILLIANS);
  }

  constructor(public messageService: MessageService) { }
}
