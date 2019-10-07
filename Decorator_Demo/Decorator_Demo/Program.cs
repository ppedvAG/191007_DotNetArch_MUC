using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var meinePizza = new Käse(new Käse(new Salami(new Käse(new Ananas(new Pizza())))));

            // Builder
            // BakePizza()
            // .WithKäse(2)
            // .WithSalami(4)
            // .MitAllesOhneScharf ...

            Console.WriteLine(meinePizza.Name);
            Console.WriteLine(meinePizza.Preis);
            Console.WriteLine(meinePizza.GetType());

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
