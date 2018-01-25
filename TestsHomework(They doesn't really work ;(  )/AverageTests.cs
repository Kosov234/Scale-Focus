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
    }
}
