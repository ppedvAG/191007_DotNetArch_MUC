using System;
using System.Collections.Generic;

namespace Aspektorientierte_Programmierung
{
    public class DatenbankRepository : IRepository
    {
        public void Delete<T>(T item)
        {
            Console.WriteLine($"Element {item} wird gelöscht...");
        }

        public IEnumerable<T> GetAll<T>()
        {
            Console.WriteLine($"Mehrere Elemente werden zurückgegeben ...");
            return null;
        }

        public T GetByID<T>(int ID)
        {
            Console.WriteLine($"Element mit der ID {ID} wird zurückgegeben");
            return default;
        }

        public void Insert<T>(T item)
        {
            Console.WriteLine($"Element {item} wird in die DB eingefügt");
        }

        public void Update<T>(T item)
        {
            Console.WriteLine($"Element {item} wird geupdatet");
        }
    }
}
