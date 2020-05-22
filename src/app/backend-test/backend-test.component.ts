import { Component, OnInit } from '@angular/core';
import {HttpClient, HttpHeaders, HttpParams} from '@angular/common/http';
import {IVillain, Villain} from '../villain';
import {VillainService} from '../villain.service';
import { Observable, of } from 'rxjs';
import { stripSummaryForJitFileSuffix } from '@angular/compiler/src/aot/util';


@Component({
  selector: 'app-backend-test',
  templateUrl: './backend-test.component.html',
  styleUrls: ['./backend-test.component.css']
})
export class BackendTestComponent implements OnInit {

  constructor(private villainService: VillainService) { }

  BackEndVillain: Villain;
  TestString: string;
  VillainData: Object;

  getVillain(villain: string) {
    let newVillain = new Villain();
    //await this.villainService.getVillainFromAPI(villain).subscribe(villainData);
    let stuff = this.villainService.getVillainFromAPI(villain).subscribe(data =>  {
      newVillain.name = data["Name"]? data["Name"] : null;
      newVillain.id = data["VillainId"]? data["VillainId"] : null;
      newVillain.description = data["Description"]? data["Description"] : null;
      newVillain.URI = null;
      newVillain.imageLocation = null;
      this.BackEndVillain = newVillain;
    });
  }

  showVillain() {
    console.log(this.BackEndVillain.name)
  }

  ngOnInit(): void {
  }

}
