using System.Collections.Generic;
namespace Library.Models
{
    public class Book
    {
        public Book()
        {
            this.Authors = new HashSet<BookAuthor>();
            this.Genres = new HashSet<BookGenre>();
        }
        public int BookId { get; set; }
        public string Title { get; set; }
        public int PubYear { get; set; }
        public ICollection<BookAuthor> Authors { get; }
        public ICollection<BookGenre> Genres { get; }
        public virtual ApplicationUser User { get; set; }
    }
}