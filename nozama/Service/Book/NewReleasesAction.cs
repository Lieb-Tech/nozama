using nozama.Repository.Book;
using System.Collections.Generic;

namespace nozama.Service.Book
{
    public partial class BookService
    {
        public class NewReleasesAction : ServiceAction
        {
            public List<NewReleaseQueryModel> GetNewReleases(int NumBooks = 5)
            {
                return _bookRepository.Factory<BookRepository.NewReleaseQuery>().Query(NumBooks);
            }
        }
    }
}
