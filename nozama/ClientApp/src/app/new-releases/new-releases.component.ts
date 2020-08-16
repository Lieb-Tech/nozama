import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-new-releases',
  templateUrl: './new-releases.component.html'
})
export class NewReleasesComponent {
  public newReleases: Book[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<NewReleasesResult >(baseUrl + 'newReleases').subscribe(result => {     
      this.newReleases = result.newReleases;      
    }, error => console.error(error));
  }
}

interface NewReleasesResult {
  newReleases: Book[];
};

class Book {
  bookTitle: string;
  bookid: number;
  authorID: number;
  authorName: string;

  clicked2(event: any) {
    alert(event);
  };
}
