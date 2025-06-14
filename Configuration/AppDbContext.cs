using Microsoft.EntityFrameworkCore;
using Quiz_2.Models.Author;
using Quiz_2.Models.Book;
using Quiz_2.Models.Genre;

namespace Quiz_2.Configuration
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
       public DbSet<Authors> Authors;
       public DbSet<Genres> Genres;
       public DbSet<Books> Books;
    }
}
