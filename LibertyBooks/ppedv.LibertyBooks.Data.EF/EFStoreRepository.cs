using ppedv.LibertyBooks.Domain;
using ppedv.LibertyBooks.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ppedv.LibertyBooks.Data.EF
{
    public class EFStoreRepository : EFUniversalRepository<Store>, IStoreRepository
    {
        public EFStoreRepository(EFContext context) : base(context) { }

        public IEnumerable<Store> GetStoresWithBookInInventory(Book input)
        {
            return context.Store.Where(x => x.Stock.Any(item => item.Book.ID == input.ID))
                                .ToArray();
        }

        public Store GetStoreWithHighestInventoryValue()
        {
            return context.Store.OrderByDescending(x => x.Stock.Sum(inv => inv.Price * inv.Amount))
                                .First();
        }
    }
}
