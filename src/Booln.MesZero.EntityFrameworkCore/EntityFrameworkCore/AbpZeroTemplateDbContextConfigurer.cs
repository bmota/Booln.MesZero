using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Booln.MesZero.EntityFrameworkCore
{
    public static class AbpZeroTemplateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpZeroTemplateDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}