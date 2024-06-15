using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TryAbp.Authorization.Roles;
using TryAbp.Authorization.Users;
using TryAbp.MultiTenancy;
using TryAbp.App.Client;

namespace TryAbp.EntityFrameworkCore
{
    public class TryAbpDbContext : AbpZeroDbContext<Tenant, Role, User, TryAbpDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TryAbpDbContext(DbContextOptions<TryAbpDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
    }
}
