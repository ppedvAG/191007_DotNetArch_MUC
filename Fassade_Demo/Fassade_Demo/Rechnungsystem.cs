using System;
using System.Threading;

namespace Fassade_Demo
{
    class Rechnungsystem
    {
        public void BezahlvorgangStarten()
        {
            Thread.Sleep(500);
            Console.WriteLine("Bezahlvorgang per PayPal");
        }

        public bool DeckelPrüfen(string Kundenname)
        {
            Console.WriteLine("Hat der Kunde noch offene Rechnungen ?");
            Thread.Sleep(5000);
            if (Kundenname == "Peter")
            {
                Console.WriteLine("BEZAHL ERST DEINE RECHNUNG !!!!");
                return false;
            }
            Console.WriteLine("Ok passt :)");
            return true;
        }
    }
}
