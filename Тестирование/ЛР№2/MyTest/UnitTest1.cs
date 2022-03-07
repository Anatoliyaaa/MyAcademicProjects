using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ЛР_2;

namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMyFF1()
        {
            FF ff = new FF();
            //ff.R = 5;
            Assert.AreEqual(true, ff.HitCheck(0, 0)); // 1
            Assert.AreEqual(true, ff.HitCheck(5, 1));
            Assert.AreEqual(true, ff.HitCheck(4, 2));
            Assert.AreEqual(true, ff.HitCheck(6, 2));
            Assert.AreEqual(true, ff.HitCheck(5, 5));
            Assert.AreEqual(false, ff.HitCheck(5, 6));
            Assert.AreEqual(false, ff.HitCheck(1, 5));

        }
        [TestMethod]
        public void TestMyFF2()
        {
            FF ff = new FF();

            Assert.AreEqual(false, ff.HitCheck(-1, 1));  // 2
            Assert.AreEqual(false, ff.HitCheck(-10, 1));
            Assert.AreEqual(false, ff.HitCheck(-5, 10));


        }

        [TestMethod]
        public void TestMyFF3()
        {
            FF ff = new FF();


            Assert.AreEqual(true, ff.HitCheck(0, -1)); //3
            Assert.AreEqual(true, ff.HitCheck(-5, 0));
            Assert.AreEqual(true, ff.HitCheck(-0.1, -0.1));
            Assert.AreEqual(false, ff.HitCheck(-10, 0));
            Assert.AreEqual(false, ff.HitCheck(-5, -5));


        }

        [TestMethod]
        public void TestMyFF4()
        {
            FF ff = new FF();
            Assert.AreEqual(false, ff.HitCheck(1, -1)); //4
            Assert.AreEqual(false, ff.HitCheck(10, -1));
            Assert.AreEqual(false, ff.HitCheck(10, -10));


        }

        [TestMethod]
        public void TestMyFF1_2()
        {
            FF ff = new FF();
            Assert.AreEqual(false, ff.HitCheck(0, 5));
            Assert.AreEqual(false, ff.HitCheck(0, 1));

        }

        [TestMethod]
        public void TestMyFF2_3()
        {
            FF ff = new FF();
            Assert.AreEqual(true, ff.HitCheck(-1, 0)); 
            Assert.AreEqual(false, ff.HitCheck(-10, 0));

        }

        [TestMethod]
        public void TestMyFF3_4()
        {
            FF ff = new FF();
            Assert.AreEqual(true, ff.HitCheck(0, -5));
            Assert.AreEqual(false, ff.HitCheck(0, -10));

        }

        [TestMethod]
        public void TestMyFF4_1()
        {
            FF ff = new FF();
            Assert.AreEqual(true, ff.HitCheck(5, 0)); 
            Assert.AreEqual(false, ff.HitCheck(11, 0));

        }

        public void TestMyFFZero()
        {
            FF ff = new FF();
            Assert.AreEqual(true, ff.HitCheck(0, 0)); 

        }

    }
}
