using ppedv.LibertyBooks.Domain;
using ppedv.LibertyBooks.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppedv.LibertyBooks.Data.EF
{
    public class EFUniversalRepository<T> : IUniversalRepository<T> where T : Entity
    {
        public EFUniversalRepository(EFContext context)
        {
            this.context = context;
        }
        protected readonly EFContext context;

        public void Delete(T item)
        {
            context.Set<T>().Remove(item);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToArray();
        }

        public T GetByID(int ID)
        {
            return context.Set<T>().Find(ID);
        }

        public void Insert(T item)
        {
            context.Set<T>().Add(item);
        }

        public IQueryable<T> Query()
        {
            return context.Set<T>();
        }

        public void Update(T item)
        {
            // 1) Element neu aus der DB holen
            var loadedItem = GetByID(item.ID);
            if (loadedItem != null)
            {
                // 2) Werte überschreiben, damit der ChangeTracker aus EF daraus ein "SQL-Update" macht
                context.Entry(loadedItem).CurrentValues.SetValues(item);
            }
        }
    }
}
