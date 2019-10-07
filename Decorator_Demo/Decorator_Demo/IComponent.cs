using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Demo
{
    public interface IComponent
    {
        string Name { get; }
        decimal Preis { get; }
    }

    public class Pizza : IComponent
    {
        public string Name => "Pizza ";
        public decimal Preis => 5m;
    }

    public abstract class Dekorator : IComponent
    {
        protected Dekorator(IComponent parent)
        {
            this.parent = parent;
        }
        protected IComponent parent;

        public abstract string Name { get; }
        public abstract decimal Preis { get; }
    }

    public class Käse : Dekorator
    {
        public Käse(IComponent parent) : base(parent){}

        public override string Name => parent.Name + "Käse ";

        public override decimal Preis => parent.Preis + 0.5m;
    }

    public class Salami : Dekorator
    {
        public Salami(IComponent parent) : base(parent) { }

        public override string Name => parent.Name + "Salami ";

        public override decimal Preis => parent.Preis + 0.8m;
    }

    public class Schinken : Dekorator
    {
        public Schinken(IComponent parent) : base(parent) { }

        public override string Name => parent.Name + "Schinken ";

        public override decimal Preis => parent.Preis + 1m;
    }

    public class Pilze : Dekorator
    {
        public Pilze(IComponent parent) : base(parent) { }

        public override string Name => parent.Name + "Pilze ";

        public override decimal Preis => parent.Preis + 1m;
    }

    public class Ananas : Dekorator
    {
        public Ananas(IComponent parent) : base(parent) { }

        public override string Name => parent.Name + "Ananas ";

        public override decimal Preis => parent.Preis + 4m;
    }
}
