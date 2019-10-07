using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fassade_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ohne Fassade:
            // 1) Teilsysteme erstelle

            EmailSystem es = new EmailSystem();
            Rechnungsystem rs = new Rechnungsystem();
            DHLLieferdienst ls = new DHLLieferdienst();
            
            if(rs.DeckelPrüfen("Michi"))
            {
                rs.BezahlvorgangStarten();
                es.BestellbestätigungSchicken();
                ls.PizzaPerDHLAusliefern();
            }



            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
