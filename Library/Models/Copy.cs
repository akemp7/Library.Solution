//Books and Copies: one-to-many relationship (one Book has many Copies, but each Copy only has one Book)
using System.Collections.Generic;
namespace Library.Models
{
    public class Copy
    {
        public Copy()
        {
            this.Checkouts = new HashSet<Checkout>();
        }
        public int CopyId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public ICollection<Checkout> Checkouts { get; }
        public virtual ApplicationUser User { get; set; }
    }
}