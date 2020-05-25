import { Component, OnInit } from '@angular/core';
import {HttpClient, HttpHeaders, HttpParams} from '@angular/common/http';
import {IVillain, Villain} from '../villain';
import {VillainService} from '../villain.service';
import { Observable, of } from 'rxjs';
import { stripSummaryForJitFileSuffix } from '@angular/compiler/src/aot/util';
import { finalize } from 'rxjs/operators';
import {SafeUrl} from '@angular/platform-browser';



@Component({
  selector: 'app-backend-test',
  templateUrl: './backend-test.component.html',
  styleUrls: ['./backend-test.component.css']
})
export class BackendTestComponent implements OnInit {

  constructor(private villainService: VillainService) { }

  BackEndVillains: Villain[];
  TestString: string;
  VillainData: Object;
  name:string;
  firstNames: String[];
  villainImageUrls: SafeUrl[];
  getVillains() {
    this.villainService.getVillains()
        .subscribe(
            (data: Villain[]) => {
              this.BackEndVillains = data;
              this.villainImageUrls = this.villainService.createBlobFromBase64(data);
              console.log(this.BackEndVillains);
              this.firstNames = this.villainService.getVillainNames(data);
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
