using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik.Trump_Edition
{
    [Export(typeof(IRechenart))]
    public class TrumpAddition : IRechenart
    {
        public int Berechne(int z1, int z2)
        {
            return z1 + z2 +  1; // Trump kann nicht rechnen :)
        }
    }
}
