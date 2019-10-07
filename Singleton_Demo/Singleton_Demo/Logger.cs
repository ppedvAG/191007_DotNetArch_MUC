using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Demo
{
    public class Logger
    {
        private Logger()
        {
            instanceCounter++;
        }

        private static int instanceCounter = 0;
        private static object lockObject = new object(); // nur für den Lock-Block

        // Alternative: Property
        private static Logger instance;
        public static Logger GetLogger()
        {
            // Erster Aufruf:
            lock (lockObject)
            {
                if (instance == null)
                    instance = new Logger();
            }

            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine($"{instanceCounter}[{DateTime.Now.ToLongTimeString()}]: {message}");
        }

    }

    // Alternative:
    public static class StaticLogger
    {
        // Vorteil:
        // * Man muss sich nicht um eine Instanz kümmern -> es gibt keine
        // * StaticLogger kann von überall aus genutzt werden

        // Nachteil:
        // * Kein Interface für StaticLogger (es gibt ja keine Instanz)
        // * Keine Instanz per se (=> Kein DependencyInjection möglich)
        // * Gültigkeit

        public static void Log()
        {
            Console.WriteLine("....");
        }
    }
}
