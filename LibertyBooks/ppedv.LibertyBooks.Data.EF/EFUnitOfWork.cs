using ppedv.LibertyBooks.Domain;
using ppedv.LibertyBooks.Domain.Interfaces;
using System;

namespace ppedv.LibertyBooks.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public EFUnitOfWork() : this(new EFContext()) { }
        public EFUnitOfWork(EFContext context)
        {
            this.context = context;
        }
        private readonly EFContext context;

        public Type[] SupportedTypes => new Type[] { typeof(Inventory), typeof(Store) };

        // Variante 1): Immer ein neues Repository zurückgeben
        public IBookRepository BookRepository => new EFBookRepository(context);
        // Variante 2): Singleton
        private IStoreRepository storeRepository;
        public IStoreRepository StoreRepository
        {
            get
            {
                storeRepository = storeRepository ?? new EFStoreRepository(context);
                return storeRepository;
            }
        }

        // Variante 3): Repository-Factory
        public IUniversalRepository<T> GetRepository<T>() where T : Entity
        {
            // Generator, der für jeden einzelen Datentypen (T) ein neues UniversalRepository zurückgibt

            // variante "leicht":
            // return new EFUniversalRepository<T>(context);

            // variante "schwer":
            // ToDo: Switch oder is-Operator einsetzen
            // ToDo: Else-Fall mit Cache
            // ToDo: IoC-Container nimmt (Autofac, Unity, CastleWindsor, SimpleIoC ...)
            if (typeof(T) == typeof(Book))
                return (IUniversalRepository<T>)BookRepository;
            else if (typeof(T) == typeof(Store))
                return (IUniversalRepository<T>)StoreRepository;
            else
                return new EFUniversalRepository<T>(context);

        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
