using ppedv.LibertyBooks.Domain;
using ppedv.LibertyBooks.Domain.Interfaces;
using System;

namespace ppedv.LibertyBooks.Data.XML
{
    public class XMLUnitOfWork : IUnitOfWork
    {
        public IBookRepository BookRepository => new XMLBookRepository();

        #region Ausgelassen für simple Variante
        public IStoreRepository StoreRepository => throw new NotImplementedException();

        public IUniversalRepository<T> GetRepository<T>() where T : Entity
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
