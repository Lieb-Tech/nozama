import { Component, Inject} from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router} from '@angular/router';

@Component({
  selector: 'app-new-releases',
  templateUrl: './new-releases.component.html'
})
export class NewReleasesComponent {
  public newReleases: Book[];
  constructor(http: HttpClient, private router: Router, @Inject('BASE_URL') baseUrl: string) {
    http.get<NewReleasesResult >(baseUrl + 'newReleases').subscribe(result => {     
      this.newReleases = result.newReleases;
    }, error => console.error(error));
  }
  clicked(event: number) {
    this.router.navigate([`fetch-data`, event]);
  }
}

interface NewReleasesResult {
  newReleases: Book[];
};

interface Book {
  bookTitle: string;
  bookID: number;
  authorID: number;
  authorName: string; 
}
