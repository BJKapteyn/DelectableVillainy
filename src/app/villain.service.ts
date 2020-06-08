import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders, HttpParams, HttpClientModule, HttpResponse} from '@angular/common/http';
import {IVillain, Villain} from './villain';
import {VILLAINS} from './mock-villains';
import {Observable, of, throwError} from 'rxjs';
import {catchError, retry, map} from 'rxjs/operators';
import {MessageService} from './message.service';
import { OptionsComponent } from './options/options.component';
import {DomSanitizer, SafeHtml, SafeUrl} from '@angular/platform-browser';

const baseURL = "https://localhost:5001/api/villain";
@Injectable({
  providedIn: 'root'
})

export class VillainService {
  constructor(
    public messageService: MessageService,
    private http: HttpClient,
    private sanitizer: DomSanitizer
  ) { };
    //options to send out with the http request
    options: {
      headers?: HttpHeaders | {[header: string]: string | string[]}
      //specifies how much or the response to return
      observe?: 'body',
      reportProgress?: boolean,
      //specifies the format to return. json is the default value, I'm just being deliberate here.
      responseType?: 'json';
      //probably going to need this when I implement identity
      withCredentials?: boolean
    }
    public firstNames: String[] = new Array();
    villainImageUrls: SafeUrl[] = new Array();
  //all back end URLs for API calls are stored here
  configURL = 'assets/config/json';

  getVillains(): Observable<Villain[]> {
    return this.http.get<Villain[]>(baseURL + "/GetAllVillains", this.options).pipe(
      map((data: Villain[]) => {

        return data;
      }),
      catchError(error => {
        return throwError(error);
      })
    );
  };
  getVillainNames(villains: Villain[]): String[]{
    for (const villain of villains) {
      this.firstNames.push(villain.FirstName);
    }
    return this.firstNames;
  }

  getVillain(URI: string): Observable<IVillain> {
    return of(VILLAINS.find(villain => villain.URI == URI));
  }



  //for now format the villain name to 'first-last' backend is expecting names separated with '-' 5/4/2020
  getVillainFromAPI(villainName: string): Observable<Villain>  {

    return this.http.get<Villain>(`${baseURL}/${villainName}`, this.options).pipe(
      map((data: Villain) => {
        return data;
      }),
      catchError(error => {
        return throwError(error);
      })
    );

  }

  base64ToArrayBuffer(base64: string) {
    const binaryString = window.atob(base64); // Comment this if not using base64
    const bytes = new Uint8Array(binaryString.length);
    return bytes.map((byte, i) => binaryString.charCodeAt(i));
  }

  createBlobFromBase64(villains: Villain[]): SafeUrl[] {
    for (const villain of villains) {
      let imgBuffer: Uint8Array = this.base64ToArrayBuffer(villain.SelfPortrait);
      let blob = new Blob([imgBuffer], {type: "image/jpg"});
      let imageUrl: SafeUrl = this.sanitizer.bypassSecurityTrustUrl(URL.createObjectURL(blob));
      this.villainImageUrls.push(imageUrl);
    }
    return this.villainImageUrls;
  }

}
