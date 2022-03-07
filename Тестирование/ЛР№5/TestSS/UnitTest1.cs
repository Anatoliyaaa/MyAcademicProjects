using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ЛР_5;

namespace TestSS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void less_zero()
        {
            
            Assert.AreEqual(SS_8_16.Convert("12"), "A");
            Assert.AreEqual(SS_8_16.Convert("7"), "7");
            Assert.AreEqual(SS_8_16.Convert("1"), "1");

        }

        [TestMethod]
        public void greater_zero()
        {
            Assert.AreEqual(SS_8_16.Convert("-1"), "-1");
            Assert.AreEqual(SS_8_16.Convert("-12"), "-A");
            Assert.AreEqual(SS_8_16.Convert("-133"), "-5B");
        }

        [TestMethod]
        public void equal_zero()
        {
            Assert.AreEqual(SS_8_16.Convert("0"), "0");
        }
    }
}
