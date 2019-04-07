using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_calculator.Test.Unit
{
    [TestClass]
    public class InputConventerTest
    {
        private readonly InputConventer _inputConventer = new InputConventer();
        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConventer.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]  //expecting a failure
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputNumber = "*";
            double convertedNumber = _inputConventer.ConvertInputToNumeric(inputNumber);
            
        }
    }
}
