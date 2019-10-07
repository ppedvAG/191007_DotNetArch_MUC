using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Demo
{
    public interface IEssen
    {
        void Beschreibung();
    }

    public class Bierzelt
    {
        public IEssen GibEssen()
        {
            return GibEssen(DateTime.Now);
        }

        public IEssen GibEssen(DateTime aktuelleUhrzeit)
        {
            if (aktuelleUhrzeit.Hour >= 6 && aktuelleUhrzeit.Hour < 11)
                return new Frühstück();
            else if (aktuelleUhrzeit.Hour >= 11 && aktuelleUhrzeit.Hour < 16)
                return new Mittagessen();
            else if (aktuelleUhrzeit.Hour >= 16 && aktuelleUhrzeit.Hour < 22)
                return new Abendessen();
            else
                return new KeinEssen();
        }
    }
}
