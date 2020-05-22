import { Component, OnInit } from '@angular/core';
import {HttpClient, HttpHeaders, HttpParams} from '@angular/common/http';
import {IVillain, Villain} from '../villain';
import {VillainService} from '../villain.service';
import { Observable, of } from 'rxjs';
import { stripSummaryForJitFileSuffix } from '@angular/compiler/src/aot/util';
import { finalize } from 'rxjs/operators';


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
  name:string;
  getVillain(villain: string) {
    this.villainService.getVillainFromAPI(villain)
        .subscribe(
            (data: Villain) => {
              this.BackEndVillain = data;
              console.log(this.BackEndVillain.FullName);

            },
            error => console.log(error)
    );
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
