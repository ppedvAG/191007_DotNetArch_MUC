using System.Collections.Generic;

namespace ppedv.LibertyBooks.Domain
{
    public class Store : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual HashSet<Inventory> Stock { get; set; } = new HashSet<Inventory>();
    }
}
