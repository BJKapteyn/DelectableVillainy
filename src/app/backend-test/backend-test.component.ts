import { Component, OnInit } from '@angular/core';
import {HttpClient, HttpHeaders, HttpParams} from '@angular/common/http';
import {Villain} from '../villain';
import {VillainService} from '../villain.service';
import { Observable } from 'rxjs';


@Component({
  selector: 'app-backend-test',
  templateUrl: './backend-test.component.html',
  styleUrls: ['./backend-test.component.css']
})
export class BackendTestComponent implements OnInit {

  constructor(private villainService: VillainService) { }

  BackEndVillain: Villain;
  TestString: string;

  getVillain(villain: string) {
    let newVillain: Villain;

    this.villainService.getVillain(villain).subscribe(val => console.log(val));

  }

  ngOnInit(): void {
  }

}
