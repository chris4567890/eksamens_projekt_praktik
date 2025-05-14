using Microsoft.VisualStudio.TestTools.UnitTesting;
using eksamn_project.Server.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace eksamn_project.Server.Utility.Tests
{
    [TestClass()]
    public class MomMomCalculatorTests
    {
        [TestMethod()]
        public void calculateTest()
        {
            var result = 36;
            int input = 14;
            MomMomCalculator calculator = new MomMomCalculator();
            var expectedvalue = calculator.calculate(input, "offentlig");
            Assert.AreEqual(expectedvalue, result);
        }
        [TestMethod()]
        public void falseTest()
        {
            var result = 3030;
            int input = 3999;
            MomMomCalculator calculator = new MomMomCalculator();
            var expectedvalue = calculator.calculate(input, "offentlig");
            Assert.IsFalse(expectedvalue.Equals(result));
            
        }
    }
}