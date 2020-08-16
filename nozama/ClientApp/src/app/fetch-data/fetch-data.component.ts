import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, ParamMap } from '@angular/router';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public book: Book;

  constructor(private http: HttpClient, private route: ActivatedRoute, @Inject('BASE_URL') private baseUrl: string) {
  }

  ngOnInit() {
    //this.route.queryParams.subscribe(params => {
      if (this.route.snapshot.url.length > 1) {
        console.log(this.route.snapshot.url[1]);
        this.loadBook(parseInt(this.route.snapshot.url[1].path));
      } else
        this.loadBook(1);
      //});
  }

  loadBook(id: number) {
    this.http.get<BookResult>(this.baseUrl + 'book\\' + id + '\\').subscribe(result => {
      this.book = result.book;
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
