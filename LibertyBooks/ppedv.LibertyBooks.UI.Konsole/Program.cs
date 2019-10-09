using ppedv.LibertyBooks.Data.EF;
using ppedv.LibertyBooks.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppedv.LibertyBooks.UI.Konsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Core core = new Core(new EFUnitOfWork(new EFContext()));

            if (core.HasData() == false)
                core.GenerateTestData();

            foreach (var store in core.GetAllStores())
            {
                Console.WriteLine($"{store.Name}: {store.Address}");
                foreach (var inv in store.Stock)
                {
                    Console.WriteLine($"\t {inv.Book.Title}: {inv.Price}€");
                }
            }

            var booksWith20Pages = core.GetAllBooksWithPages(20).ToArray();

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
