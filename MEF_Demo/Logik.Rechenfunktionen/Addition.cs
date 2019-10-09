using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik.Rechenfunktionen
{
    [Export(typeof(IRechenart))]
    public class Addition : IRechenart
    {
        public int Berechne(int z1, int z2)
        {
            return z1 + z2;
        }
    }
}
