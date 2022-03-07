using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ЛР_3;

namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGoodWay()
        {
            Assert.AreEqual("5078705", FF.ChangeStrInStr("66", "0", "566787665"));
        }

        [TestMethod]
        public void TestBadWay()
        {
            Assert.AreEqual("566787665", FF.ChangeStrInStr("9", "0", "566787665"));
        }

        [TestMethod]
        public void TestS1_Null()
        {
            Assert.AreEqual("566787665", FF.ChangeStrInStr("", "0", "566787665"));
        }

        [TestMethod]
        public void TestS2_Null()
        {
            Assert.AreEqual("57875", FF.ChangeStrInStr("66", "", "566787665"));
        }

        [TestMethod]
        public void TestS_Null()
        {
            Assert.AreEqual("", FF.ChangeStrInStr("66", "0", ""));
        }
    }
}
