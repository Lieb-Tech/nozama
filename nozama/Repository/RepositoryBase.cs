using nozama.Util;
namespace nozama.Repository
{
    public abstract class RepositoryBase : IRepositoryBase
    {
        protected readonly IConnectionManager _connectionMananager;
        public RepositoryBase(IConnectionManager connectionMananager)
        {
            _connectionMananager = connectionMananager;
        }

        public T Factory<T>() where T : RepositoryCommandQuery, new()
        {
            var ret = new T();
            ret.SetConnectionManager(_connectionMananager);
            return ret;
        }
    }
}
