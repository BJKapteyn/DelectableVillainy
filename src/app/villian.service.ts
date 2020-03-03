import { Injectable } from '@angular/core';
import {Villian} from './villian';
import {VILLIANS} from './mock-villians';
import {Observable, of} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class VillianService {

  getVillians(): Observable<Villian[]> {
    return of(VILLIANS);
  }
  constructor() { }
}
