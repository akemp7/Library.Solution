using System.Collections.Generic;
namespace Library.Models
{
    public class Author
    {
        public Author()
        {
            this.Books = new HashSet<BookAuthor>();
        }
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<BookAuthor> Books { get; }
        public virtual ApplicationUser User { get; set; }
    }
}