using Microsoft.VisualStudio.TestTools.UnitTesting;
using eksamn_project.Server.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eksamn_project.Server.Utility.Tests
{
    [TestClass()]
    public class SingleMomCalculatorTests
    {
        [TestMethod()]
        public void calculateTest()
        {
            int output = 36;
            int input = 14;
            SingleMomCalculator calculator = new SingleMomCalculator();
            var result = calculator.calculate(input,"offentlig");

            Assert.AreEqual(output, result);
        }
        [TestMethod()]
        public void calculatefalse()
        {
            int output = 29;
            int input = 14;
            SingleMomCalculator calculator = new SingleMomCalculator();
            var result = calculator.calculate(input, "offentlig");
            Assert.AreNotEqual(output, result);
        }
    }
}