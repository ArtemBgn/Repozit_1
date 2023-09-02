using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Tests
{
    [TestClass()]
    public class CalcTests
    {
        [TestMethod()]
        public void sumTest()
        {
            Assert.IsTrue(4 == Calc.sum(2, 2), "2+2=4");
            Assert.IsTrue(4000000000 == Calc.sum(2000000000, 2000000000), "2G + 2G == 4G");
            Assert.IsTrue(0 == Calc.sum(2, -2), "2 + -2 == 0");
            Assert.IsTrue(0 == Calc.sum(-2, 2), "-2 + 2 == 0");
            Assert.IsTrue(0 == Calc.sum(0, 0), "0 + 0 == 0");
            Assert.IsTrue(-4 == Calc.sum(-2, -2), "-2 + -2 == -4");
            Assert.IsTrue((decimal)0.3 == Calc.sum(0.1, 0.2), "0.1 + 0.2 == 0.3");
            Assert.IsTrue((decimal)0.6 == Calc.sum(0.2, 0.4), "0.2 + 0.4 == 0.6");
            Assert.IsTrue((decimal)0.9 == Calc.sum(0.3, 0.6), "0.3 + 0.6 == 0.9");
            Assert.IsTrue((decimal)0.8 == Calc.sum(0.1, 0.7), "0.1 + 0.7 == 0.8");
            Assert.IsTrue((decimal)0.9 == Calc.sum(0.2, 0.7), "0.2 + 0.7 == 0.9");
            Assert.IsTrue((decimal)0.8 == Calc.sum(0.7, 0.1), "0.7 + 01 == 0.8");
            Assert.IsTrue(40000000000 == Calc.sum(10000000000, 30000000000), "1G + 3G == 4G");
        }

        [TestMethod()]
        public void subTest()
        {
            Assert.IsTrue(0 == Calc.sub(2, 2), "2-2=0");
            Assert.IsTrue(4000000000 == Calc.sum(2000000000, 2000000000), "2G - 2G == 0");
            Assert.IsTrue(4 == Calc.sub(2, -2), "2 - -2 == 4");
            Assert.IsTrue(-4 == Calc.sub(-2, 2), "-2 - 2 == -4");
            Assert.IsTrue(0 == Calc.sub(0, 0), "0 - 0 == 0");
            Assert.IsTrue(0 == Calc.sub(-2, -2), "-2 - -2 == 0");
            Assert.IsTrue((decimal)0.3 == Calc.sub(1, 0.7), "1 - 0.7 == 0.3");
            Assert.IsTrue((decimal)0.2 == Calc.sub(1, 0.8), "1 - 0.8 == 0.2");
            Assert.IsTrue((decimal)0.1 == Calc.sub(1, 0.9), "1 - 0.9 == 0.1");
            Assert.IsTrue((decimal)0.1 == Calc.sub(0.9, 0.8), "0.9 - 0.8 == 0.1");
            Assert.IsTrue((decimal)0.2 == Calc.sub(0.9, 0.7), "0.9 - 0.7 == 0.2");
            Assert.IsTrue((decimal)0.3 == Calc.sub(0.9, 0.6), "0.9 - 0.6 == 0.3");
            Assert.IsTrue((decimal)0.6 == Calc.sub(0.9, 0.3), "0.9 - 0.3 == 0.6");
            Assert.IsTrue((decimal)0.6 == Calc.sub(0.9, 0.3), "0.9 - 0.3 == 0.6");
        }

        [TestMethod()]
        public void multTest()
        {
            Assert.IsTrue(4 == Calc.mult(2, 2), "2 * 2 = 4");
            Assert.IsTrue(0 == Calc.mult(0, 2), "0 * 2 = 0");
            Assert.IsTrue(0 == Calc.mult(2, 0), "2 * 0 = 0");
            Assert.IsTrue(2 == Calc.mult(2, 1), "2 * 1 = 2");
            Assert.IsTrue(-2 == Calc.mult(2, -1), "2 * -1 = -2");
            Assert.IsTrue(2 == Calc.mult(1, 2), "1 * 2 = 2");
            Assert.IsTrue(-2 == Calc.mult(-1, 2), "-1 * 2 = -2");
            Assert.IsTrue(2 == Calc.mult(-1, -2), "-1 * -2 = 2");
            Assert.IsTrue((decimal)0.09 == Calc.mult(0.1, 0.9), "0.1 * 0.9 = 0.09");
            Assert.IsTrue((decimal)-0.09 == Calc.mult(-0.1, 0.9), "-0.1 * 0.9 = -0.09");
            Assert.IsTrue((decimal)-0.09 == Calc.mult(0.1, -0.9), "0.1 * -0.9 = -0.09");
            Assert.IsTrue((decimal)0.09 == Calc.mult(-0.1, -0.9), "-0.1 * -0.9 = 0.09");
        }

        [TestMethod()]
        public void divTest()
        {
            Assert.IsTrue(1 == Calc.div(2, 2), "2 / 2 = 1");
            Assert.IsTrue(2 == Calc.div(4, 2), "4 / 2 = 2");
            Assert.IsTrue((decimal)2.5 == Calc.div(5, 2), "5 / 2 = 2.5");
            Assert.IsTrue((decimal)0.2 == Calc.div(1, 5), "1 / 5 = 0.2");
            Assert.IsTrue(10 == Calc.div(1, 0.1), "1 / 0.1 = 10");
            Assert.IsTrue(-10 == Calc.div(1, -0.1), "1 / -0.1 = -10");
            Assert.IsTrue(10 == Calc.div(-1, -0.1), "-1 / -0.1 = 10");
        }

        [TestMethod()]
        public void remOfdivTest()
        {
            Assert.IsTrue(0 == Calc.remOfdiv(2, 2), "2 % 2 = 0");
            Assert.IsTrue(1 == Calc.remOfdiv(3, 2), "3 % 2 = 1");
            Assert.IsTrue((decimal)0.1 == Calc.remOfdiv(2.1, 2), "2.1 % 2 = 0.1");
        }
    }
}