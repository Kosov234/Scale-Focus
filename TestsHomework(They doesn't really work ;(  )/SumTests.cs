using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class SumTests
    {
        [TestMethod]
        public void SumTestWrongRange()
        {
            Assert.AreEqual(0,Methods.BasicMethods.Sum(10,6));
        }
        [TestMethod]
        public void SumTestNegativeRange()
        {
            Assert.AreEqual(-40, Methods.BasicMethods.Sum(-10, -6));
        }
        [TestMethod]
        public void SumTestNegativeWrongRange()
        {
            Assert.AreEqual(0, Methods.BasicMethods.Sum(-6,-10));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SumTestOutOfRange()
        {
            Methods.BasicMethods.Sum(2,2147483647);
        }
    }
}
