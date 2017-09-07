using Microsoft.Extensions.Configuration;

namespace Booln.MesZero.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
