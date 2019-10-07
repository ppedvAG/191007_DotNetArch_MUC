using System;
using System.Threading;

namespace Fassade_Demo
{
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
