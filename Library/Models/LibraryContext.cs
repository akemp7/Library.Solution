using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
  public class LibraryContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Copy> Copies { get; set; }
    public DbSet<Patron> Patrons { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<BookAuthor> BookAuthor { get; set; }
    public DbSet<BookGenre> BookGenre { get; set; }
    public DbSet<Checkout> Checkouts { get; set; }

    public LibraryContext(DbContextOptions options) : base(options) { }
  }
}