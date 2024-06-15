using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TryAbp.EntityFrameworkCore
{
    public static class TryAbpDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TryAbpDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TryAbpDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
