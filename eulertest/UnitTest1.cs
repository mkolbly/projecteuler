using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using euler;

namespace eulertest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testp1()
        {
            Assert.AreEqual(23, p1.multiples(3, 5, 9));
        }
    }
}
