using Domain;
using Logik.Rechenfunktionen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEF_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Taschenrechner tr = new Taschenrechner();

            var erg = tr.Rechenart.Berechne(12, 3);
            Console.WriteLine(erg);

            Console.WriteLine("---ANFANG---");
            Console.ReadKey();
        }
    }

    class Taschenrechner
    {
        public Taschenrechner()
        {
            Rechenart = new Addition();
        }
        // Normalerweise
        public IRechenart Rechenart { get; }
    }
}
