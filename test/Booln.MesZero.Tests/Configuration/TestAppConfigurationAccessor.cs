using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using Booln.MesZero.Configuration;

namespace Booln.MesZero.Tests.Configuration
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(AbpZeroTemplateTestModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
