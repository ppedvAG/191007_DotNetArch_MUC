using ppedv.LibertyBooks.Data.EF;
using ppedv.LibertyBooks.Data.XML;
using ppedv.LibertyBooks.Domain;
using ppedv.LibertyBooks.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ppedv.LibertyBooks.UI.Konsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Core core = new Core(new XMLUnitOfWork());

            #region EF - Code
            //if (core.HasData() == false)
            //    core.GenerateTestData();

            //foreach (var store in core.GetAllStores())
            //{
            //    Console.WriteLine($"{store.Name}: {store.Address}");
            //    foreach (var inv in store.Stock)
            //    {
            //        Console.WriteLine($"\t {inv.Book.Title}: {inv.Price}€");
            //    }
            //}

            //var booksWith20Pages = core.GetAllBooksWithPages(20).ToArray(); 
            #endregion

            // XML-Daten

            if (File.Exists("Books.xml") == false)
            { // XML-Testdaten erstellen
                Book[] books = new Book[]
                {
                    new Book
                    {
                         Author = "Tom Ate",
                         Title = "Mein kleiner Garten",
                         Pages = 200,
                         Genre = Genre.Crime,
                         Price = 2m
                    },
                    new Book
                    {
                        Author = "Anna Nass",
                        Title = "Pina Colada leicht gemacht",
                        Pages = 10,
                        Genre = Genre.Drama | Genre.Comic,
                        Price = 200m
                    },
                    new Book
                    {
                        Author = "Peter Silie",
                        Title = "Küchengewürze 101",
                        Pages = 101,
                        Genre = Genre.Health,
                        Price = 9.99m
                    },
                    new Book
                    {
                        Author = "Martha Pfahl",
                        Title = "Winnetou",
                        Pages = 201,
                        Genre = Genre.Romance | Genre.Travel | Genre.Fiction,
                        Price = 19.99m
                    },
                    new Book
                    {
                        Author = "Albert Ross",
                        Title = "Das Fest des Huhns - Limited Edition",
                        Pages = 2,
                        Genre = Genre.Children | Genre.Health | Genre.NonFiction,
                        Price = 500m
                    } };

                XmlSerializer serializer = new XmlSerializer(typeof(Book[]));
                FileStream stream = new FileStream("Books.xml", FileMode.Create);
                serializer.Serialize(stream,books);
                stream.Close();
            }

            var booksAusXML = core.GetAllBooks();
            var booksWith20Pages = core.GetAllBooksWithPages(20).ToArray(); 


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
