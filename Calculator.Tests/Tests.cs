using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Library;

namespace Calculator.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestAdd()
        {
            var calc = new CalculatorService();

            var result = calc.Sum(1, 2);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMinus()
        {
            var calc = new CalculatorService();

            var result = calc.Minus(1, 2);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestMultiply()
        {
            var calc = new CalculatorService();

            var result = calc.Multiply(3, 2);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestDivide()
        {
            var calc = new CalculatorService();

            var result = calc.Divide(4, 2);

            Assert.AreEqual(2, result);
        }
    }
}
