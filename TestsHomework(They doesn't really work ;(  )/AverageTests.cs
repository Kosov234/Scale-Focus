using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class AverageTest
    {
        [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
        public void TestAverageWithZero()
        {
            Methods.BasicMethods.Average(0);
        }
        [TestMethod]
        public void AverageMinValue()
        {
            Assert.AreEqual(0, Methods.BasicMethods.Average(-32768));

        }
        public void AverageMaxValue()
        {
            Assert.AreEqual(16384, Methods.BasicMethods.Average(32767));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestPalindromOutOfMaxRange()
        {
            Methods.BasicMethods.Average(32769);
        }
   }
}
