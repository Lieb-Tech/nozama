using nozama.Repository.Book;

namespace nozama.Service.Book
{
    public partial class BookService : ServiceBase, IBookService
    {        
        public BookService(IBookRepository bookRepositiory)
        {
            _serviceActionConfiguration = new ServiceActionConfiguration()
            {
                BookRepository = bookRepositiory
            };
        }
    }
}
