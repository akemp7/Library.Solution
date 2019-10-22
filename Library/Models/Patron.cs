
namespace Library.Models
{
    public class Patron
    {
        public Patron()
        {
            this.Copies = new HashSet<PatronCopies>();
        }
        public int PatronId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<PatronCopy> Copies { get; }
        public virtual ApplicationUser User { get; set; }
    }
}