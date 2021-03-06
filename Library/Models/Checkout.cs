//Patrons and Copies: many-to-many relationship (A patron + a copy = a Checkout)
namespace Library.Models
{
    public class Checkout
    {
        public int CheckoutId { get; set; }
        public int BookId { get; set; }
        public int PatronId { get; set; }
        public Book Book { get; set; }
        public Patron Patron { get; set; }
    }
}