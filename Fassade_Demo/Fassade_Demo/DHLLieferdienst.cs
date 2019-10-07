using System;
using System.Threading;

namespace Fassade_Demo
{
    class DHLLieferdienst
    {
        public void PizzaPerDHLAusliefern()
        {
            Thread.Sleep(8000);
            Console.WriteLine("DHL Lieferwagen liefert aus ...");
        }
    }
}
