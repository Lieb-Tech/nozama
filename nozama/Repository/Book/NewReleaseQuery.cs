using Dapper;
using nozama.Util;
using System.Collections.Generic;
using System.Linq;

namespace nozama.Repository.Book
{
    public partial class BookRepository
    {
        public class NewReleaseQuery : RepositoryCommandQuery
        {
            public List<NewReleaseQueryModel> Query(int NumBooks)
            {
                var conn = _connectionManager.Connection(ConnectionManagerTypes.Catalog);

                var sql = $"SELECT TOP {NumBooks} m.* " +
                    "FROM mvBook as m " +
                    "JOIN Book as b on b.BookID = m.BookID " +
                    "ORDER BY Added DESC";
                return conn.Query<NewReleaseQueryModel>(sql,
                            null,
                            commandType: System.Data.CommandType.Text
                        ).ToList();
            }
        }
    }
}
