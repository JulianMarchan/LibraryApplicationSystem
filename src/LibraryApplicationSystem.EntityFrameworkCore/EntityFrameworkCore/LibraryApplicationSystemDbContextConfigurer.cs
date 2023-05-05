using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LibraryApplicationSystem.EntityFrameworkCore
{
    public static class LibraryApplicationSystemDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LibraryApplicationSystemDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LibraryApplicationSystemDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
