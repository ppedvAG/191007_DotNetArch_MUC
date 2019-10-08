using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ppedv.LibertyBooks.Data.EF.Tests
{
    [TestClass]
    public class EFContextTests
    {
        [TestMethod]
        public void Can_Create_EFContext()
        {
            EFContext context = new EFContext();

            Assert.IsNotNull(context); // Wenn sie Null ist -> Fehler
        }

        [TestMethod]
        public void Can_Create_Database()
        {
            EFContext context = new EFContext();
            if (context.Database.Exists())
                context.Database.Delete();

            Assert.IsFalse(context.Database.Exists());

            context.Database.Create();

            Assert.IsTrue(context.Database.Exists()); // Wenn sie Null ist -> Fehler
        }
    }
}
