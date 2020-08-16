using nozama.Repository.Book;

namespace nozama.Service
{
    public class ServiceActionConfiguration
    {
        public IBookRepository BookRepository { get; set; }
    }
}
