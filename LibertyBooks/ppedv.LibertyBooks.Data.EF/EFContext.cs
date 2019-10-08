using ppedv.LibertyBooks.Domain;
using System;
using System.Data.Entity;

namespace ppedv.LibertyBooks.Data.EF
{
    public class EFContext : DbContext
    {
        // ConnectionString:
        // TeilnehmerPC: "Server=.;Database=LibertyBooks;Trusted_Connection=true"
        // TrainerPC: "Server=(localdb)\MSSQLLocalDB;....."
        public EFContext() : this(@"Server=(localdb)\MSSQLLocalDB;Database=LibertyBooks;Trusted_Connection=true;AttachDbFilename=C:\temp\LibertyBooks.mdf"){}
        public EFContext(string connectionString) : base(connectionString){}

        public DbSet<Book> Book { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Store> Store { get; set; }
    }
}
