using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IntegratedTesting;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSin() //Синус
        {
            Assert.AreEqual(Math.Round(Math.Sin(60 * Math.PI / 180), 4), Math.Round(IntegratedTesting.TrigonomF.TrigFunc.Sin(60*Math.PI/180),4));
        }

        [TestMethod]
        public void TestMethodCos() //Косинус
        {
            Assert.AreEqual(Math.Round(Math.Cos(60 * Math.PI / 180), 4), Math.Round(IntegratedTesting.TrigonomF.TrigFunc.Cos(60 * Math.PI / 180), 4));
        }

        [TestMethod]
        public void TestMethodAbs() //Модуль
        {
            Assert.AreEqual(Math.Abs(-90), IntegratedTesting.TrigonomF.TrigFunc.Abs(-90));
        }

        [TestMethod]
        public void TestMethodPower() //Возведение в степень
        {
            Assert.AreEqual(Math.Pow(5,2),IntegratedTesting.TrigonomF.TrigFunc.Power(5,2));
        }

        [TestMethod]
        public void TestMethodTan() //Тангенс
        {
            Assert.AreEqual(Math.Round(Math.Tan(60 * Math.PI / 180), 4), Math.Round(IntegratedTesting.TrigonomF.TrigFunc.Tan(60 * Math.PI / 180), 4));
        }

        [TestMethod]
        public void TestMethodCTan() //Котангенс
        {
            Assert.AreEqual(Math.Round(1/ Math.Tan(60 * Math.PI / 180), 4), Math.Round(IntegratedTesting.TrigonomF.TrigFunc.Ctan(60 * Math.PI / 180), 4));
        }

        [TestMethod]
        public void TestMethodFactorial() //Факториал
        {
            Assert.AreEqual(120, IntegratedTesting.TrigonomF.TrigFunc.Factorial(5));
        }

        [TestMethod]
        public void TestMethodSec() //Секонс
        {
            Assert.AreEqual(Math.Round(1 / Math.Cos(60 * Math.PI / 180), 4), Math.Round(IntegratedTesting.TrigonomF.TrigFunc.sec(60 * Math.PI / 180), 4));
        }
    }
}
