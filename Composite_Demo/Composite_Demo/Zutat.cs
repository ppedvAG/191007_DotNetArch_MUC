using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Demo
{
    public abstract class Zutat
    {
        public abstract string Name { get; set; }
        public abstract int Menge { get; set; }
        public abstract int KcalPro100g { get; set; }
        public int KcalTotal => Convert.ToInt32(KcalPro100g * (Menge / 100));
    }
}
