using System.Collections.Generic;

namespace ppedv.LibertyBooks.Domain.Interfaces
{
    public interface IStoreRepository : IUniversalRepository<Store>
    {
        Store GetStoreWithHighestInventoryValue();
        IEnumerable<Store> GetStoresWithBookInInventory(Book input);
    }
}
