namespace ppedv.LibertyBooks.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        // Spezial:
        IBookRepository BookRepository { get; }
        IStoreRepository StoreRepository { get; }

        // Allgemein: RepositoryFactory
        IUniversalRepository<T> GetRepository<T>() where T : Entity;

        void Save(); // Speichern gilt für alle Repositories
    }
}
