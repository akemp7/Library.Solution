using System.Collections.Generic;
namespace Library.Models
{
    public class Patron
    {
        public Patron()
        {
            this.Checkouts = new HashSet<Checkout>();
        }
        public int PatronId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Checkout> Checkouts { get; }
        public virtual ApplicationUser User { get; set; }
    }
}