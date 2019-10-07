using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Lebensmittel Fleischlaberl = new Lebensmittel { Name = "Fleischlaberl aus Biohaltung", Menge = 250, KcalPro100g = 300 };
            Lebensmittel Tomate = new Lebensmittel { Name = "Feldtomate vom Feld", Menge = 25, KcalPro100g = 10 };
            Lebensmittel Gurkerl = new Lebensmittel { Name = "Gartengurkerl ausm Vorgarten", Menge = 10, KcalPro100g = 1 };

            Kochrezept Ketchup = new Kochrezept();
            Ketchup.Name = "Heinz Tomatenketchup XXXL mega süß";
            Ketchup.Zutatenliste.Add(new Lebensmittel
            {
                Name = "Zucker",
                Menge = 2,
                KcalPro100g = 200
            });
            Ketchup.Zutatenliste.Add(new Lebensmittel
            {
                Name = "Wasser",
                Menge = 4,
                KcalPro100g = 0
            });
            Ketchup.Zutatenliste.Add(new Lebensmittel
            {
                Name = "Tomatenmark",
                Menge = 4,
                KcalPro100g = 30
            });

            Kochrezept Sesamvollkornbrot = new Kochrezept
            {
                Name = "Veganes Glutenfreies Sesamvollkornbrot"
            };
            Sesamvollkornbrot.Zutatenliste.Add(new Lebensmittel
            {
                Name = "Glutenfreies Mehl",
                Menge = 50,
                KcalPro100g = 50
            });
            Sesamvollkornbrot.Zutatenliste.Add(new Lebensmittel
            {
                Name = "Glutenfreies Wasser",
                Menge = 100,
                KcalPro100g = 0
            });
            Sesamvollkornbrot.Zutatenliste.Add(new Lebensmittel
            {
                Name = "Glutenfreies Sesam",
                Menge = 50,
                KcalPro100g = 20
            });
            // Lebensmittel Ketchup = new Lebensmittel { Name="Heinz Ketchup" }

            Kochrezept Burger = new Kochrezept
            {
                Name = "Gesund Öko Greta-Burger"
            };
            Burger.Zutatenliste.Add(Fleischlaberl);
            Burger.Zutatenliste.Add(Tomate);
            Burger.Zutatenliste.Add(Gurkerl);
            Burger.Zutatenliste.Add(Ketchup);
            Burger.Zutatenliste.Add(Sesamvollkornbrot);

            Console.WriteLine($"Menge in Gramm: {Burger.Menge}");
            Console.WriteLine($"Kcal: {Burger.KcalTotal}");

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
