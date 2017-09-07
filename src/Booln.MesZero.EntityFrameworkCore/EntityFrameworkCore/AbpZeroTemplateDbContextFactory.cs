using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Booln.MesZero.Configuration;
using Booln.MesZero.Web;

namespace Booln.MesZero.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpZeroTemplateDbContextFactory : IDbContextFactory<AbpZeroTemplateDbContext>
    {
        public AbpZeroTemplateDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<AbpZeroTemplateDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbpZeroTemplateDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpZeroTemplateConsts.ConnectionStringName));
            
            return new AbpZeroTemplateDbContext(builder.Options);
        }
    }
}