//Books and Genres: many-to-many relationship
namespace Library.Models
{
    public class BookGenre
    {
        public int BookGenreId { get; set; }
        public int GenreId { get; set; }
        public int BookId { get; set; }
        public Genre Genre { get; set; }
        public Book Book { get; set; }
    }
}