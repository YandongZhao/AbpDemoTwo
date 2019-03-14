using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AbpDemoTwo.Authorization.Roles;
using AbpDemoTwo.Authorization.Users;
using AbpDemoTwo.MultiTenancy;

namespace AbpDemoTwo.EntityFrameworkCore
{
    public class AbpDemoTwoDbContext : AbpZeroDbContext<Tenant, Role, User, AbpDemoTwoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AbpDemoTwoDbContext(DbContextOptions<AbpDemoTwoDbContext> options)
            : base(options)
        {
        }
    }
}
