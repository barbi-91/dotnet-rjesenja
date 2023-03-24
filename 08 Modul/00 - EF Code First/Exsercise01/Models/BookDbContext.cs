using Microsoft.EntityFrameworkCore;

namespace Exsercise01.Models
{
    public class BookDbContext : DbContext
    {
        public DbSet<Book> Books { get; set;}
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }
    }
}
