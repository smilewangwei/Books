using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BookList.EntityFrameworkCore
{
    public static class BookListDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BookListDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BookListDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
