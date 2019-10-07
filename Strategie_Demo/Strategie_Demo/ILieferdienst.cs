using System;
using System.Threading;

namespace Strategie_Demo
{
    public interface ILieferdienst
    {
        void ProduktAusliefern();
    }

    public class DHLLieferdienst : ILieferdienst
    {
        public void ProduktAusliefern()
        {
            Thread.Sleep(8000);
            Console.WriteLine("DHL Lieferwagen liefert aus ...");
        }
    }

    public class LuigiLieferdienst : ILieferdienst
    {
        public void ProduktAusliefern()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Luigi liefert persönlich mit dem Moped ...");
        }
    }
}
