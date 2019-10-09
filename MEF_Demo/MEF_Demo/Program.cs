using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.Composition;// MEF -> Managed Extensibility Framework
using System.ComponentModel.Composition.Hosting;

namespace MEF_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Taschenrechner tr = new Taschenrechner();

            // MEF -> Lade die Komponente in "Rechenart" hinein:

            // 1) "Von wo kommen die Datentypen?"
            DirectoryCatalog catalog = new DirectoryCatalog("."); // aus dem selben Verzeichnis der .EXE
            CompositionContainer container = new CompositionContainer(catalog);
            // 2) Taschenrechner mit implementierung füllen
            container.ComposeParts(tr);

            var erg = tr.Rechenart[0].Berechne(12, 3);
            Console.WriteLine(erg);

            Console.WriteLine("---ANFANG---");
            Console.ReadKey();
        }
    }

    class Taschenrechner
    {
        public Taschenrechner()
        {
            #region Variante mit Reflection
            //var dll = Assembly.LoadFrom("Logik.Rechenfunktionen.dll");
            //var addType = dll.GetType("Logik.Rechenfunktionen.Addition"); // Namespace.Klassenname

            //Rechenart = (IRechenart)Activator.CreateInstance(addType); 
            #endregion
        }

        // [Import(typeof(IRechenart))] // Alternative [Import("meinName")]-> object
        [ImportMany(typeof(IRechenart))] // Alternative [Import("meinName")]-> object
        public IRechenart[] Rechenart { get; set; }
    }
}
