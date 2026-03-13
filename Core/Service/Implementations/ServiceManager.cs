
using ServiceAbstraction.Contracts;

namespace Service.Implementations
{
    public class ServiceManager
        (Func<ILocationService> locationFactory
        ):IServiceManager
    {
        public ILocationService LocationService => locationFactory.Invoke();

    }
}
