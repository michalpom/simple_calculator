using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_calculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResoultForNonSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate(number1, number2, "add");
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResoultForSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate(number1, number2, "+");
            Assert.AreEqual(3, result);
        }
    }
}
