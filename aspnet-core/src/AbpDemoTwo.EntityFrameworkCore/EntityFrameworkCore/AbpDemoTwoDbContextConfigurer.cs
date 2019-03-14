using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AbpDemoTwo.EntityFrameworkCore
{
    public static class AbpDemoTwoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpDemoTwoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpDemoTwoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
