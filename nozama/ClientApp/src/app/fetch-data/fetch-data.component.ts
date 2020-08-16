import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public book: Book;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<BookResult>(baseUrl + 'book\\1\\').subscribe(result => {     
      this.book = result.book;
      console.log(this.book);
    }, error => console.error(error));
  }
}

interface BookResult {
  book: Book;
};

interface Book {
  title: string;
  synopsis: string;
  bookid: number;
  authorID: number;
  authorName: string;
}
