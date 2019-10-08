namespace ppedv.LibertyBooks.Domain
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }
        public Genre Genre { get; set; }
    }
}
