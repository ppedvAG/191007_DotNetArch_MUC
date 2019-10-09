using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.Composition; // MEF
namespace Domain
{
    public interface IRechenart
    {
        int Berechne(int z1, int z2);
    }
}
