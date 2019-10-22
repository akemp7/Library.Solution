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
    public DbSet<BookAuthor> BookAuthor { get; set; }
    public DbSet<BookCopy> BookCopy { get; set; }
    public DbSet<PatronCopy> PatronCopy { get; set; }

    public LibraryContext(DbContextOptions options) : base(options) { }
  }
}