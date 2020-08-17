import { Component, Inject, Renderer2 } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { SearchServiceService } from '../search-service.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent {
  public dropDownVisible: boolean;
  searchText: string;
  history: string[];

  constructor(private renderer: Renderer2,
    private http: HttpClient,    
    private searchService: SearchServiceService,
    @Inject('BASE_URL') private baseUrl: string,) {
    this.history = this.searchService.getHistory();    
  }

  public setSearchText(search: string) {
    console.log("set: " + search);
    this.searchText = search;    
  }

  doSearch() {
    console.log("search: " + this.searchText);
    this.searchService.addHistory(this.searchText);
    this.history.push(this.searchText);
    this.searchText = "";
  }

  showDropdown(): void {
    const vals = this.history.slice();
    this.dropDownVisible = (vals.length > 0);
  }

  hideDropdown(): void {    
    this.dropDownVisible = false;
  } 
}
