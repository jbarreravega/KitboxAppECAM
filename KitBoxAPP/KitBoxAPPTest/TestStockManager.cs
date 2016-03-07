using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KitBoxAPP;

namespace KitBoxAPPTest
{
    [TestClass]
    public class TestStockManager
    {
        [TestMethod]
        public void Get()
        {
            DBManager mgr = new DBManager(true);

            Piece p = mgr.Stock.Get("POR5262VE");

            Assert.AreEqual("POR5262VE", p.Code);
            Assert.AreEqual("Porte", p.Name);
            Assert.AreEqual((double)52.0, p.Height);
            Assert.AreEqual((double)0.0, p.Depth);
            Assert.AreEqual((double)62.0, p.Width);
            Assert.AreEqual((int)46, p.StockQuantity);
            Assert.AreEqual((int)16, p.MinQuantity);
            Assert.AreEqual((int)0, p.ReservedQuantity);
            Assert.AreEqual((double)32.24, p.PriceClient);
            Assert.IsNotNull(p.Color);
            Assert.AreEqual("Verre", p.Color.Name);
            Assert.IsNotNull(p.PriceSuppliers);
            Assert.AreEqual((double)27.45, p.PriceSupplier(1));
            Assert.AreEqual((double)20.61, p.PriceSupplier(2));
            Assert.AreEqual((int)8, p.DeliveryTime(1));
            Assert.AreEqual((int)17, p.DeliveryTime(2));
        }

        [TestMethod]
        public void List()
        {
            DBManager mgr = new DBManager(true);

            Piece p = mgr.Stock.Get("POR5262VE");
        }
    }
}
