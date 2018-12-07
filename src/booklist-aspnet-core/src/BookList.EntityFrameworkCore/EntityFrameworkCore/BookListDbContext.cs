using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BookList.Authorization.Roles;
using BookList.Authorization.Users;
using BookList.MultiTenancy;
using BookList.BooklistManagement.Books;
using BookList.BooklistManagement.Booklists;
using BookList.BooklistManagement.BookTags;

namespace BookList.EntityFrameworkCore
{
    public class BookListDbContext : AbpZeroDbContext<Tenant, Role, User, BookListDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public BookListDbContext(DbContextOptions<BookListDbContext> options)
            : base(options)
        {
        }

        #region 书单功能实体

        public DbSet<Book> Books { get; set; }

        public DbSet<Booklist> Booklists { get; set; }

        public DbSet<BookTag> BookTags { get; set; }

        #endregion
    }
}
