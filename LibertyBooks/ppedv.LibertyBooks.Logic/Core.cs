using ppedv.LibertyBooks.Domain;
using ppedv.LibertyBooks.Domain.Interfaces;
using System;

namespace ppedv.LibertyBooks.Logic
{
    public class Core
    {
        public Core(IRepository repository)
        {
            this.repository = repository;
        }
        private readonly IRepository repository;

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

            repository.Insert(s1);
            repository.Insert(s2);
            repository.Insert(s3);

            repository.Save();
        }
    }
}
