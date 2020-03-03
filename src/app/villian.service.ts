import { Injectable } from '@angular/core';
import {Villian} from './villian';
import {VILLIANS} from './mock-villians';

@Injectable({
  providedIn: 'root'
})
export class VillianService {

  getVillians(): Villian[] {
    return VILLIANS;
  }
  constructor() { }
}
