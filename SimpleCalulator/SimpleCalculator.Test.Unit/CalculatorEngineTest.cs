using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SimpleCalulator;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly  CalculatorEngine _calcEngine = new CalculatorEngine();
            
        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calcEngine.Calculate("add", number1, number2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calcEngine.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);
        }


    }
}
