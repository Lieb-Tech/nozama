using nozama.Repository.Book;

namespace nozama.Service.Book
{
    public partial class BookService
    {
        public class BookByIDAction : ServiceAction
        {
            public BookByIDQueryModel BookByID(long ID)
            {
                return _bookRepository.Factory<BookRepository.BookByIDQuery>().Query(ID);
            }
        }
    }
}
