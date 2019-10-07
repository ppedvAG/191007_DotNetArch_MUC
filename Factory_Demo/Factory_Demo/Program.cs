using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            Bierzelt zelt1 = new Bierzelt();

            var lecker = zelt1.GibEssen();

            lecker.Beschreibung();

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
