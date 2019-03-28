using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalcTest;
namespace Calculator_Unittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calculator_Sum_ValidValue()
        {
            Calculator calculator = new Calculator();
            var result = calculator.sum(2, 5);
            Assert.AreEqual(7, result);
        }


        [TestMethod]
        public void Calculator_Sum_ValidValue2()
        {
            Calculator calculator = new Calculator();
            var result = calculator.sum(3, 7);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Calculator_Sum_InValidValue()
        {
            Calculator calculator = new Calculator();
            var result = calculator.sum(2, 5);
            Assert.AreNotEqual(6, result);
        }
    }
}
