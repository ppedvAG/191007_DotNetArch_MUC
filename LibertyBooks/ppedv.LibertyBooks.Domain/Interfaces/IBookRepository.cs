namespace ppedv.LibertyBooks.Domain.Interfaces
{
    // Extra-Features
    public interface IBookRepository : IUniversalRepository<Book>
    {
        Book GetBookWithHighestPrice();
        int GetTotalAmountOfBooksInCirculation(Book input);
    }
}
