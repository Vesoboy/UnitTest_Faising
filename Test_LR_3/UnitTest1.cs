using LR_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_LR_3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int len = 10000;
            var test_rand = new Rand(len);
            Assert.AreEqual(test_rand.StrRand(), (2 * len));
        }
    }
}