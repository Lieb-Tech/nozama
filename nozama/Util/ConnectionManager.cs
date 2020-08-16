using System.Data.SqlClient;

namespace nozama.Util
{
    public class ConnectionManager : IConnectionManager
    {
        public SqlConnection Connection(ConnectionManagerTypes connectionType)
        {
            return new SqlConnection($@"Server=localhost\SQLExpress;Database=Huntsman;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
    }
}
