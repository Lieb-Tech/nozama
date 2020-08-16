
namespace nozama.Service
{
    public abstract class ServiceBase
    {
        public ServiceActionConfiguration _serviceActionConfiguration { get; protected set; }

        public T Factory<T>() where T : ServiceAction, new()
        {
            var ret = new T();
            ret.Init(_serviceActionConfiguration);
            return ret;
        }
    }
}
