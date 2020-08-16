
using nozama.Util;

namespace nozama.Repository
{
    public abstract class RepositoryCommandQuery : IRepositoryCommandQuery
    {
        protected IConnectionManager _connectionManager { get; private set; }
        
        public void SetConnectionManager(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }
    }
}
