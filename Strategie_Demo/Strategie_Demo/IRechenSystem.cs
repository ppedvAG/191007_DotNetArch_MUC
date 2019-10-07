using System;
using System.Threading;

namespace Strategie_Demo
{
    public interface IRechenSystem
    {
        void BezahlvorgangStarten();
        bool DeckelPrüfen(string Kundenname);
    }

    public class DeckelRechner : IRechenSystem
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

    public class Supercomputer : IRechenSystem
    {
        public void BezahlvorgangStarten()
        {
            Thread.Sleep(10);
            Console.WriteLine("Bezahlvorgang per Fingerabdruck");
        }

        public bool DeckelPrüfen(string Kundenname)
        {
            Console.WriteLine("Hat der Kunde noch offene Rechnungen ?");
            if (Kundenname == "Peter")
            {
                Console.Beep();
                Console.WriteLine("SOCIAL CREDIT SCORE WIRD VERRINGERT !!!!");
                return false;
            }
            Console.WriteLine("Ok passt :)");
            return true;
        }
    }
}
