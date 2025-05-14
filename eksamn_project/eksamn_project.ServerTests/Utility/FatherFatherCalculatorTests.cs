using Microsoft.VisualStudio.TestTools.UnitTesting;
using eksamn_project.Server.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;

namespace eksamn_project.Server.Utility.Tests
{
    [TestClass()]
    public class FatherFatherCalculatorTests
    {
        [TestMethod()]
        public void calculateTest()
        {
            int input = 29;
            FatherFatherCalculator fatherFatherCalculator = new FatherFatherCalculator();
            var expectedvalue = fatherFatherCalculator.calculate(7, "offentlig");
            Assert.AreEqual(input, expectedvalue);
        }
        [TestMethod()]
        public void calculateFalseTest()
        {
            int input = 20;
            FatherFatherCalculator fatherFatherCalculator = new FatherFatherCalculator();
            var exptedvalue = fatherFatherCalculator.calculate(7, "offentlig");
            Assert.AreNotEqual(input, exptedvalue);
        }
    }
}