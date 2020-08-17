import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SearchServiceService {
  
  constructor() {
    this.history = [];
  }

  private history: string[];

  public addHistory(value: string) {
    this.history.push(value);
  }

  public getHistory() {    
    return this.history.slice();
  }
}
