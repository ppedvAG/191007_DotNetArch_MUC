using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Strategie_Demo
{
    public class LuigisPizzaria
    {
        public LuigisPizzaria(IBenachrichtigungsSystem benachrichtigungsSystem, IRechenSystem rechenSystem, ILieferdienst lieferdienst)
        {
            this.benachrichtigungsSystem = benachrichtigungsSystem;
            this.rechenSystem = rechenSystem;
            this.lieferdienst = lieferdienst;
        }

        private IBenachrichtigungsSystem benachrichtigungsSystem;
        private IRechenSystem rechenSystem;
        private ILieferdienst lieferdienst;

        public void PizzaBestellen(string Kundenname)
        {
            if (rechenSystem.DeckelPrüfen(Kundenname))
            {
                rechenSystem.BezahlvorgangStarten();
                benachrichtigungsSystem.SendeBestätigung();

                Console.WriteLine("Pizza wird in den Ofen geschoben");
                Thread.Sleep(5000);
                Console.WriteLine("Pizza ist fertig :) ");

                lieferdienst.ProduktAusliefern();
            }
        }
    }
}
