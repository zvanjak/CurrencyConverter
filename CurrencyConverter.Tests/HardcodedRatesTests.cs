using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CurrencyConverter.Tests
{
    [TestClass]
    public class HardcodedRatesTests
    {
        [TestMethod]
        public void TestDollarToKuna()
        {
            SimpleCurrencyConverter cc = new SimpleCurrencyConverter();

            cc.Init();

            Assert.AreEqual(6.693657f, cc.GetRateForDate(new DateTime(2016, 6, 1), "Dollar", "Kuna"));

            Assert.AreEqual(6.739179f, cc.GetRateForDate(new DateTime(2016, 7, 1), "Dollar", "Kuna"));
            Assert.AreEqual(6.710826f, cc.GetRateForDate(new DateTime(2016, 8, 1), "Dollar", "Kuna"));
            Assert.AreEqual(6.690581f, cc.GetRateForDate(new DateTime(2016, 9, 1), "Dollar", "Kuna"));
            Assert.AreEqual(6.701386f, cc.GetRateForDate(new DateTime(2016, 10, 1), "Dollar", "Kuna"));
            Assert.AreEqual(6.827300f, cc.GetRateForDate(new DateTime(2016, 11, 1), "Dollar", "Kuna"));
            Assert.AreEqual(7.054304f, cc.GetRateForDate(new DateTime(2016, 12, 1), "Dollar", "Kuna"));
        }
        [TestMethod]
        public void TestEuroToKuna()
        {
            SimpleCurrencyConverter cc = new SimpleCurrencyConverter();

            cc.Init();

            Assert.AreEqual(7.459411f, cc.GetRateForDate(new DateTime(2016, 6, 1), "Euro", "Kuna"));
            Assert.AreEqual(7.455057f, cc.GetRateForDate(new DateTime(2016, 8, 1), "Euro", "Kuna"));
            Assert.AreEqual(7.488799f, cc.GetRateForDate(new DateTime(2016, 10, 1), "Euro", "Kuna"));
            Assert.AreEqual(7.512834f, cc.GetRateForDate(new DateTime(2016, 12, 1), "Euro", "Kuna"));

        }

    }
}
