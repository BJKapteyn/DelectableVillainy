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
    debugger;
    //await this.villainService.getVillainFromAPI(villain).subscribe(villainData);
    let stuff = this.villainService.getVillainFromAPI(villain).subscribe(data =>  {
      this.BackEndVillain = data;
    });

    console.log(this.BackEndVillain.name);



    // this.villainService.getVillainFromAPI(villain).subscribe(data => this.BackEndVillain = {
    //   name: data["Name"],
    //   description: data["Description"],
    //   id: data["VillainId"]
    // });
  }

  assignVillain(data: Object) {
    this.VillainData = data;
  }

  ngOnInit(): void {
  }

}
