using System.Data.SqlClient;

namespace nozama.Util
{
    public interface IConnectionManager
    {
        SqlConnection Connection(ConnectionManagerTypes connectionType); 
    }
}
