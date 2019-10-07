using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategie_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            LuigisPizzaria lp = new LuigisPizzaria(new BrieftaubenSystem(),new Supercomputer(),new LuigiLieferdienst());

            lp.PizzaBestellen("Michi");

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
