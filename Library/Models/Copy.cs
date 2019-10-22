
namespace Library.Models
{
    public class Copy
    {
        public Copy()
        {
            this.Books = new HashSet<BookCopy>();
        }
        public int CopyId { get; set; }
        public ICollection<BookCopy> Books { get; }
        public virtual ApplicationUser User { get; set; }
    }
}