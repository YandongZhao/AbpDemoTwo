using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AbpDemoTwo.Configuration;
using AbpDemoTwo.Web;

namespace AbpDemoTwo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpDemoTwoDbContextFactory : IDesignTimeDbContextFactory<AbpDemoTwoDbContext>
    {
        public AbpDemoTwoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbpDemoTwoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbpDemoTwoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpDemoTwoConsts.ConnectionStringName));

            return new AbpDemoTwoDbContext(builder.Options);
        }
    }
}
