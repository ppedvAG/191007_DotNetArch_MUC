using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspektorientierte_Programmierung
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository repo = new LoggerRepository(new DatenbankRepository());

            Person p1 = new Person { Vorname = "Tom", Nachname = "Ate", Alter = 10, Kontostand = 100 };

            repo.Insert(p1);
            repo.Update(p1);
            repo.GetByID<Person>(123);
            repo.GetAll<Person>();
            repo.Delete(p1);

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
