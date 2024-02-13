using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TCFQ.Repository.Context;

namespace TCFQ.WF.Configuration
{
    internal static class ProgramMainConfiguration
    {
        public static IServiceCollection AddAppDbContext(this IServiceCollection serviceCollection, string stringConnection, string mySqlVersion)
        {
            serviceCollection.AddDbContext<AppDbContext>(options =>
                options.UseMySql(stringConnection, ServerVersion.Create(
                        new Version(mySqlVersion),
                        Pomelo.EntityFrameworkCore.MySql.Infrastructure.ServerType.MySql)
                   ));

            return serviceCollection;
        }

        public static IConfigurationRoot AddJsonFileConfig(this IConfigurationBuilder configurationBuilder)
        {
            return configurationBuilder
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}
