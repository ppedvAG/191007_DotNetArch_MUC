using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fassade_Demo
{
    class EmailSystem
    {
        public void BestellbestätigungSchicken()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Email - Bestellbestätigung wird geschickt");
        }
    }

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

    class LuigiLieferdienst
    {
        public void PizzaAusliefern()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Luigi fährt mit der Pizza auf dem Roller los...");
        }
    }

    class DHLLieferdienst
    {
        public void PizzaPerDHLAusliefern()
        {
            Thread.Sleep(8000);
            Console.WriteLine("DHL Lieferwagen liefert aus ...");
        }
    }

    class LuigisPizzaria
    {

       private EmailSystem es = new EmailSystem();
       private Rechnungsystem rs = new Rechnungsystem();
       private DHLLieferdienst ls = new DHLLieferdienst();

        public void PizzaBestellen(string Kundenname)
        {
            if (rs.DeckelPrüfen(Kundenname))
            {
                rs.BezahlvorgangStarten();
                es.BestellbestätigungSchicken();

                Console.WriteLine("Pizza wird in den Ofen geschoben");
                Thread.Sleep(5000);
                Console.WriteLine("Pizza ist fertig :) ");

                ls.PizzaPerDHLAusliefern();
            }
        }
    }
}
