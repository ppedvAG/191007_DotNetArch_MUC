using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fassade_Demo
{
    class EmailSystem
    {
        public void BestellbestätigungSchicken()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Email - Bestellbestätigung wird geschickt");
        }
    }
}
