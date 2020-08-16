using nozama.Repository.Book;

namespace nozama.Service
{
    public class ServiceAction
    {
        protected IBookRepository _bookRepository { get; private set; }

        public void Init(ServiceActionConfiguration configuration)
        {
            _bookRepository = configuration.BookRepository;
        }
    }
}
