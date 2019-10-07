using System;

namespace Factory_Demo
{
    public class Frühstück : IEssen
    {
        public void Beschreibung()
        {
            Console.WriteLine("Weißwurst mit Brezn und Bier");
        }
    }
}
