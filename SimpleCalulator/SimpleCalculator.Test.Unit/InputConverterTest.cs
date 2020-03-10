using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalulator;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter inputConvertertext = new InputConverter();
        [TestMethod]
        public void ConvertsValidStringInputToDouble()
        {
            string inputNumber = "5";
            double convertedNumber = inputConvertertext.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertsValidStringInputToDouble()
        {
            string inputNumber = "+";
            double convertedNumber = inputConvertertext.ConvertInputToNumeric(inputNumber);
           // Assert.AreEqual(5, convertedNumber);
        }

    }
}
