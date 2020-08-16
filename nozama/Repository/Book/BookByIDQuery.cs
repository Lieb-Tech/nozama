using Dapper;
using nozama.Util;
using System.Linq;

namespace nozama.Repository.Book
{
    public partial class BookRepository 
    {
        public class BookByIDQuery : RepositoryCommandQuery
        {
            public BookByIDQueryModel Query(long BookID)
            {
                var conn = _connectionManager.Connection(ConnectionManagerTypes.Catalog);

                var sql = "SELECT m.*, Synopsis " +
                    "FROM mvBook as m " +
                    "JOIN Book as b on b.BookID = m.BookID " +
                    "WHERE m.BookID = @ID";
                return conn.Query<BookByIDQueryModel>(sql,
                            new { ID = BookID },
                            commandType: System.Data.CommandType.Text
                        ).FirstOrDefault();
            }
        }
    }
}
