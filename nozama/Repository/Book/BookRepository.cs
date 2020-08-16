
using nozama.Util;

namespace nozama.Repository.Book
{
    public partial class BookRepository: RepositoryBase, IBookRepository
    {
        public BookRepository(IConnectionManager connectionManager) : base(connectionManager) { }
       
    }
}
