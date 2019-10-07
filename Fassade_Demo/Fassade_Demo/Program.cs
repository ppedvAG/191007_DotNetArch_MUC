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
            #region Ohne Fassade:
            // 1) Teilsysteme erstelle

            //EmailSystem es = new EmailSystem();
            //Rechnungsystem rs = new Rechnungsystem();
            //DHLLieferdienst ls = new DHLLieferdienst();

            //if(rs.DeckelPrüfen("Michi"))
            //{
            //    rs.BezahlvorgangStarten();
            //    es.BestellbestätigungSchicken();
            //    ls.PizzaPerDHLAusliefern();
            //} 
            #endregion

            LuigisPizzaria pizzaria = new LuigisPizzaria();

            pizzaria.PizzaBestellen("Michael");

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
