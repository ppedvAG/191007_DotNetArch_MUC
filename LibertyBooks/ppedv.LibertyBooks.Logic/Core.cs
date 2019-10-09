using ppedv.LibertyBooks.Domain;
using ppedv.LibertyBooks.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ppedv.LibertyBooks.Logic
{
    public class Core
    {
        public Core(params IUnitOfWork[] UoW)
        {
            this.UoW = UoW;
        }
        private readonly IUnitOfWork[] UoW; // privat -> nur Core darf drauf zugreifen

        // Für alle anderen: UoW-FactoryMethode, die einem das richtige UoW gibt
        public IUnitOfWork GetUnitOfWorkFor<T>()
        {
            return UoW.First(x => x.SupportedTypes.Contains(typeof(T)));
            // ToDo: wenn nichts gefunden -> Exception werfen
        }


        public void GenerateTestData()
        {
            Book b1 = new Book
            {
                Author = "Tom Ate",
                Title = "Mein kleiner Garten",
                Pages = 200,
                Genre = Genre.Crime,
                Price = 2m
            };
            Book b2 = new Book
            {
                Author = "Anna Nass",
                Title = "Pina Colada leicht gemacht",
                Pages = 10,
                Genre = Genre.Drama | Genre.Comic,
                Price = 200m
            };
            Book b3 = new Book
            {
                Author = "Peter Silie",
                Title = "Küchengewürze 101",
                Pages = 101,
                Genre = Genre.Health,
                Price = 9.99m
            };
            Book b4 = new Book
            {
                Author = "Martha Pfahl",
                Title = "Winnetou",
                Pages = 201,
                Genre = Genre.Romance | Genre.Travel | Genre.Fiction,
                Price = 19.99m
            };
            Book b5 = new Book
            {
                Author = "Albert Ross",
                Title = "Das Fest des Huhns - Limited Edition",
                Pages = 2,
                Genre = Genre.Children | Genre.Health | Genre.NonFiction,
                Price = 500m
            };

            Store s1 = new Store
            {
                Name="Emmas Bücherladen",
                Address="Hauptstraße 1",
            };
            s1.Stock.Add(new Inventory { Book = b1, Amount = 200, Price = 2.5m });
            s1.Stock.Add(new Inventory { Book = b2, Amount = 1, Price = 255.99m });
            s1.Stock.Add(new Inventory { Book = b3, Amount = 10, Price = 16.99m });

            Store s2 = new Store
            {
                Name = "Toms Klapperkiste",
                Address = "Seitengasse 2",
            };

            s2.Stock.Add(new Inventory { Book = b2, Amount = 3, Price = 199m });
            s2.Stock.Add(new Inventory { Book = b3, Amount = 5000, Price = 14.99m });
            s2.Stock.Add(new Inventory { Book = b4, Amount = 2, Price = 2.49m });

            Store s3 = new Store
            {
                Name = "Altpapier und Co",
                Address = "Feldweg 3",
            };
            s3.Stock.Add(new Inventory { Book = b3, Amount = 3, Price = 17.99m });
            s3.Stock.Add(new Inventory { Book = b4, Amount = 5, Price = 18.99m });
            s3.Stock.Add(new Inventory { Book = b5, Amount = 500, Price = 500.50m });

            var uow = GetUnitOfWorkFor<Store>();

            uow.StoreRepository.Insert(s1);
            uow.StoreRepository.Insert(s2);
            uow.StoreRepository.Insert(s3);

            uow.Save();
        }
        public bool HasData()
        {
            return GetAllBooks().Count() > 0; // Wenn wir Bücher haben -> true, wenn nicht -> false
        }

        public IEnumerable<Book> GetAllBooks()
        {
            // Holt sich die Daten aus XML
            return GetUnitOfWorkFor<Book>().BookRepository.GetAll();
        }
        public IEnumerable<Book> GetAllBooksWithPages(int minimumPages)
        {
            return GetAllBooks().Where(x => x.Pages >= minimumPages);
        }
        public IEnumerable<Store> GetAllStores()
        {
            //Holt sich die Daten aus EF
            return GetUnitOfWorkFor<Store>().StoreRepository.GetAll();
        }

    }
}
