import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders, HttpParams} from '@angular/common/http';
import {Villain} from './villain';
import {VILLAINS} from './mock-villains';
import {Observable, of, throwError} from 'rxjs';
import {catchError, retry} from 'rxjs/operators';
import {MessageService} from './message.service';

@Injectable({
  providedIn: 'root'
})

export class VillainService {
  //options to send out with the http request
  options: {
    //specifies how much or the response to return
    observe?: 'body',
    reportProgress?: boolean,
    //specifies the format to return. json is the default value, I'm just being deliberate here.
    responseType?: 'json';
    //probably going to need this when I implement identity
    withCredentials?: boolean
  }

  //all back end URLs for API calls are stored here
  configURL = 'assets/config/json';

  getVillains(): Observable<Villain[]> {
    return of(VILLAINS);
  };

  getVillain(URI: string): Observable<Villain> {
    return of(VILLAINS.find(villain => villain.URI == URI));
  }

  //for now format the villain name to 'first-last' backend is expecting names separated with '-' 5/4/2020
  getVillainFromAPI(villainName: string): Observable<Object>  {
    debugger;
    const URL = "https://localhost:44313" + "/" + villainName;

    return this.http.get(URL, this.options);

  }

  constructor(public messageService: MessageService,
    private http: HttpClient) { };
}
