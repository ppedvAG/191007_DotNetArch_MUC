using System;
using System.Collections.Generic;
using System.Linq;

namespace Composite_Demo
{
    public class Kochrezept : Zutat // Aufgabenliste
    {
        public List<Zutat> Zutatenliste { get; set; } = new List<Zutat>();
        public override string Name { get; set; }
        // Menge und Kcal hängen von den eigenen Zutaten ab
        public override int Menge 
        {
            get
            {
                return Zutatenliste.Sum(x => x.Menge);
            }
            set => throw new NotImplementedException();
        }
        public override int KcalPro100g 
        {
            get
            {
                return Zutatenliste.Sum(x => x.KcalTotal);
            }
            set => throw new NotImplementedException();
        }
    }
}
