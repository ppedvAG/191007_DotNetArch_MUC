using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppedv.LibertyBooks.Domain.Interfaces
{
    // Minimum-Features für jeden
    public interface IUniversalRepository<T> where T : Entity
    {
        void Insert(T item);
        void Update(T item);
        void Delete(T item);
        T GetByID(int ID);
        IEnumerable<T> GetAll();
        IQueryable<T> Query(); // Für LINQ in EF
    }
}
