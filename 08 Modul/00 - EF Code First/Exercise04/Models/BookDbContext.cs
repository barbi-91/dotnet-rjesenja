using Microsoft.EntityFrameworkCore;

namespace Exercise04.Models
{
    public class BookDbContext: DbContext
    {
        public DbSet<Book> Books { get; set;}
        public DbSet<Author> Authors { get; set;}

        public BookDbContext(DbContextOptions<BookDbContext>options): base(options) 
        {

        }
    }
}
