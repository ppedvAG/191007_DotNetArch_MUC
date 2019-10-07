using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Burger burger1 = Burger.BaueMeinenBurger()
                                   .MitGurkerl()
                                   .MitTomate(false)
                                   .MitSauce(Sauce.CocktailSauce)
                                   .MitFleisch(Fleischsorte.Rind)
                                   .MitAnzahlvonFleischlaberl(3)
                                   .BurgerBestellen();

            Burger burger2 = Burger.BaueMeinenBurger()
                                    .MitGurkerl(false)
                                    .MitSalat(true)
                                    .MitTomate(true)
                                    .MitSauce(Sauce.Ketchup)
                                    .MitFleisch(Fleischsorte.KeinFleischlaberl)
                                    .MitAnzahlvonFleischlaberl(0)
                                    .BurgerBestellen();

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
