using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEF_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Taschenrechner tr = new Taschenrechner();

            var erg = tr.Rechenart.Berechne(12, 3);
            Console.WriteLine(erg);

            Console.WriteLine("---ANFANG---");
            Console.ReadKey();
        }
    }

    class Taschenrechner
    {
        public Taschenrechner()
        {
            // Variante mit Reflection
            var dll = Assembly.LoadFrom("Logik.Rechenfunktionen.dll");
            var addType = dll.GetType("Logik.Rechenfunktionen.Addition"); // Namespace.Klassenname

            Rechenart = (IRechenart)Activator.CreateInstance(addType);
        }
        // Normalerweise
        public IRechenart Rechenart { get; }
    }
}
