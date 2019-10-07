using System;
using System.Threading;

namespace Strategie_Demo
{
    public interface IBenachrichtigungsSystem
    {
        void SendeBestätigung();
    }

    public class EmailSystem : IBenachrichtigungsSystem
    {
        public void SendeBestätigung()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Email - Bestellbestätigung wird geschickt");
        }
    }

    public class SMSSystem : IBenachrichtigungsSystem
    {
        public void SendeBestätigung()
        {
            Thread.Sleep(3000);
            Console.WriteLine("SMS - Bestellbestätigung wird geschickt");
        }
    }

    public class BrieftaubenSystem : IBenachrichtigungsSystem
    {
        public void SendeBestätigung()
        {
            Thread.Sleep(15000);
            Console.WriteLine("*pieppiep* - Bestellbestätigung wird geschickt");
        }
    }
}
