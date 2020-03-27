using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeCoverageDemoProject1;

namespace CodeCoverageTests
{
    [TestClass]
    public class ArithmeticTests
    {
        [TestMethod()]
        public void MulTest()
        {
            Arithmetic a = new Arithmetic();
            int c = a.Mul(-10, -20);
            Assert.AreEqual(c, 200);
        }

        [TestMethod()]
        public void SubTest()
        {
            Arithmetic a = new Arithmetic();
            int c = a.Sub(-10, -20);
            Assert.AreEqual(c, 10);
        }

        [TestMethod()]
        public void AddTest()
        {
            Arithmetic a = new Arithmetic();
            int c = a.Add(-10, -20);
            Assert.AreEqual(c, 30);
        }

        [TestMethod()]
        public void DivTest()
        {
            Arithmetic a = new Arithmetic();
            int c = a.Div(-10, -20);
            Assert.AreEqual(c, 0);
        }

        [TestMethod()]
        public void IsGreaterthanZeroTest()
        {
            Arithmetic ar = new Arithmetic();
            ar.IsGreaterthanZero(-20);
        }
    }
}
