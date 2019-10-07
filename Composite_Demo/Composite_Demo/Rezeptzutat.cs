namespace Composite_Demo
{
    public class Lebensmittel : Zutat // Einzelaufgabe
    {
        public override string Name { get; set; }
        public override int Menge { get; set; }
        public override int KcalPro100g { get; set; }
    }
}
