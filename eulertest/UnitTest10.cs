using System;
using euler;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eulertest
{
    [TestClass]
    public class UnitTest10
    {
        [TestMethod]
        public void TestMethod1()
        {
            long sum = 0;
            for (long i = 0; i < 2000000; i++)
            {
                if (Mathx.IsPrime(i))
                {
                    sum += i;
                }
            }

            long total = sum;

        }
    }
}
