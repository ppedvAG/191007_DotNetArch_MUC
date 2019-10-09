using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Techniken
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Erweiterungsmethoden
            int zahl = 42;

            int doppelt = zahl * 2;
            int doppelt2 = Erweiterungsmethoden.Verdoppeln(zahl);
            int doppelt3 = zahl.Verdoppeln();

            string demo = "Hallo Welt";
            Console.WriteLine(demo.Umdrehen());  
            #endregion

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
