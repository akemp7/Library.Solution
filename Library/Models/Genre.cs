using System.Collections.Generic;
namespace Library.Models
{
    public class Genre
    {
        public Genre()
        {
            this.Books = new HashSet<BookGenre>();
        }
        public int GenreId { get; set; }
        public string Name { get; set; }
        public ICollection<BookGenre> Books { get; }
        public virtual ApplicationUser User { get; set; }
    }
}