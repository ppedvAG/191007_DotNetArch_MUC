using ppedv.LibertyBooks.Domain;
using ppedv.LibertyBooks.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppedv.LibertyBooks.Data.EF
{
    public class EFRepository : IRepository
    {
        public EFRepository(EFContext context)
        {
            this.context = context;
        }
        private readonly EFContext context;

        public void Delete<T>(T item) where T : Entity
        {
            context.Set<T>().Remove(item);
        }

        public IEnumerable<T> GetAll<T>() where T : Entity
        {
            return context.Set<T>().ToArray();
        }

        public T GetByID<T>(int ID) where T : Entity
        {
            return context.Set<T>().Find(ID);
        }

        public void Insert<T>(T item) where T : Entity
        {
            context.Set<T>().Add(item);
        }

        public IQueryable<T> Query<T>() where T : Entity
        {
            return context.Set<T>();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update<T>(T item) where T : Entity
        {
            // 1) Element neu aus der DB holen
            var loadedItem = GetByID<T>(item.ID);
            if(loadedItem != null)
            {
                // 2) Werte überschreiben, damit der ChangeTracker aus EF daraus ein "SQL-Update" macht
                context.Entry(loadedItem).CurrentValues.SetValues(item);
            }
        }
    }
}
