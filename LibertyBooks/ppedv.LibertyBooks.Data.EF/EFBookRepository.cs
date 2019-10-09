using ppedv.LibertyBooks.Domain;
using ppedv.LibertyBooks.Domain.Interfaces;
using System;
using System.Linq;
using System.Text;

namespace ppedv.LibertyBooks.Data.EF
{
    public class EFBookRepository : EFUniversalRepository<Book>, IBookRepository
    {
        public EFBookRepository(EFContext context) : base(context) { }

        public Book GetBookWithHighestPrice()
        {
            return context.Book.OrderByDescending(x => x.Price)
                               .First();
        }

        public int GetTotalAmountOfBooksInCirculation(Book input)
        {
            return context.Inventory.Where(x => x.Book.ID == input.ID)
                                    .Sum(x => x.Amount);
        }
    }
}
