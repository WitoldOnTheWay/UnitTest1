using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountingApp;

namespace KalkulatorTests
{
    [TestClass]
    public class KalkulatorTests
    {
        [TestMethod]
        public void AdditionMethodTest()
        {
           int expected = 4;
            Kalkulator kalkulator = new Kalkulator();
            int actual=kalkulator.Addition(2,2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubstractionMethodTest()
        {
            int expected = 3;
            Kalkulator kalkulator = new Kalkulator();
            int actual = kalkulator.Substraction(5, 2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultiplicationMethodTest()
        {
            int expected = 25;
            Kalkulator kalkulator = new Kalkulator();
            int actual = kalkulator.Multiplication(5, 5);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivisionMethodTest()
        {
            int expected = 4;
            Kalkulator kalkulator = new Kalkulator();
            int actual = kalkulator.Division(12, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void DivisionByZeroMethodTest()
        {
            Kalkulator kalkulator = new Kalkulator();
            int actual = kalkulator.Division(12, 0);
        }
}
}
