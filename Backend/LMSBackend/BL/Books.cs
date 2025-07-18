namespace libary.Books
{

    public class Book
    {

        public string Name;
        public int Isbn;
        public string Author;
        public string Publisher;
        public float price;

        public Book(string Name, int Isbn, string Author, string Publisher, float price)
        {
            this.Name = Name;
            this.Isbn = Isbn;
            this.Author = Author;
            this.Publisher = Publisher;
            this.price = price;
        }
    }
}   