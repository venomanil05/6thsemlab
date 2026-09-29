using Microsoft.EntityFrameworkCore;

namespace q8.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(
            DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
