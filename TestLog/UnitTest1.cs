using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestLog
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodLn() //Натуральный логарифм
        {
            int x = 0;
            Assert.AreEqual(Math.Round(Math.Log(1-x), 4), Math.Round(IntegratedTesting.Log.LogFunc.Ln1MinusX(x), 4));
        }
    }
}
