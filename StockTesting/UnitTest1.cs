using IndexListIceTask;

namespace StockTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestID()
        {
            Stock st = new Stock(9, "CH0169", "Lindt slab", "Lindt", "Sweets");
            Assert.AreEqual(st[0], "CH0169");
        }
        [TestMethod]
        public void TestSupplierValidity()
        {
            Stock st = new Stock(9, "CH0169", "Lindt slab", "Lindt", "Sweets");
            Assert.AreEqual(st[2], "Cadbury");
        }
        [TestMethod]
        public void TestUpdateName()
        {
            Stock st = new Stock(9, "CH0169", "Lindt slab", "Lindt", "Sweets");
            st[1] = "Hazelnut Lindt Bar";
            Assert.AreEqual(st[1], "Hazelnut Lindt Bar");
        }
        [TestMethod]
        public void TestUpdateCategory()
        {
            Stock st = new Stock(9, "CH0169", "Lindt slab", "Lindt", "Sweets");
            st[3] = "Chocolate";
            Assert.AreEqual(st[3], "Chocolate");
        }
        [TestMethod]
        public void TestPriceValidity()
        {
            Stock st = new Stock(9, "CH0169", "Lindt slab", "Lindt", "Sweets");
            Assert.IsInstanceOfType(st[4], typeof(double));
        }
    }
}