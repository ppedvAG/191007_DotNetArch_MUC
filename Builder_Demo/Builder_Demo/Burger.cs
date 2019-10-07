using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Demo
{
    public enum Fleischsorte { KeinFleischlaberl, Pute, Rind, Schwein, Ratte, Veganes_Irgendwas };
    public enum Sauce { Ketchup, Majo, Senf, CocktailSauce };
    public class Burger
    {
        private Burger()
        {

        }

        public Sauce Sauce { get; set; }
        public Fleischsorte Fleisch { get; set; }
        public int AnzahlFleischlaberl { get; set; }
        public bool Salat { get; set; }
        public bool Tomate { get; set; }
        public bool Gurkerl { get; set; }

        public static Builder BaueMeinenBurger()
        {
            return new Builder();
        }

        public class Builder
        {
            // Defaultwerte im Konstruktor (0 Fleisch, kein Gurkerl :( usw...)
            private Burger zuBauenderBurger = new Burger();

            public Builder MitGurkerl(bool mitGurkerl = true)
            {
                zuBauenderBurger.Gurkerl = mitGurkerl;
                return this;
            }
            public Builder MitSalat(bool mitSalat)
            {
                zuBauenderBurger.Salat = mitSalat;
                return this;
            }
            public Builder MitTomate(bool mitTomate)
            {
                if (mitTomate == true)
                {
                    if (zuBauenderBurger.Salat == true)
                        zuBauenderBurger.Tomate = mitTomate;
                    else
                        throw new ArgumentException("Tomate darf nur mit Salat gewählt werden");
                }
                else
                    zuBauenderBurger.Tomate = false;

                return this;
            }
            public Builder MitSauce(Sauce gewählteSauce)
            {
                zuBauenderBurger.Sauce = gewählteSauce;
                return this;
            }
            public Builder MitFleisch(Fleischsorte gewähltesFleisch)
            {
                if (gewähltesFleisch == Fleischsorte.Veganes_Irgendwas)
                {
                    throw new ArgumentException("Security: Kunde bitte abführen !!!");
                }
                else
                    zuBauenderBurger.Fleisch = gewähltesFleisch;
                return this;
            }
            public Builder MitAnzahlvonFleischlaberl(int anzahl)
            {
                if (zuBauenderBurger.Fleisch == Fleischsorte.KeinFleischlaberl)
                    zuBauenderBurger.AnzahlFleischlaberl = 0;
                else
                    zuBauenderBurger.AnzahlFleischlaberl = anzahl;

                return this;
            }

            public Burger BurgerBestellen()
            {
                return zuBauenderBurger;
            }
        }

    }
}
