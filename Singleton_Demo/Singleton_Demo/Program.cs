using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logger.GetLogger().Log("Hallo Welt");
            //Logger.GetLogger().Log("123");
            //Logger.GetLogger().Log("Demolog");

            Parallel.For(0, 10000, i =>
              {
                  Logger.GetLogger().Log(i.ToString());
              });


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
