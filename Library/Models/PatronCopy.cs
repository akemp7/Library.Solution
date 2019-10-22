
namespace Library.Models
{
    public class PatronCopy
    {
        public int PatronCopyId { get; set; }
        public int CopyId { get; set; }
        public int PatronId { get; set; }
        public Copy Copy { get; set; }
        public Patron Patron { get; set; }
    }
}