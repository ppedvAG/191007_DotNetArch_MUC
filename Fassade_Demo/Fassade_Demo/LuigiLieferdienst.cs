using System;
using System.Threading;

namespace Fassade_Demo
{
    class LuigiLieferdienst
    {
        public void PizzaAusliefern()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Luigi fährt mit der Pizza auf dem Roller los...");
        }
    }
}
