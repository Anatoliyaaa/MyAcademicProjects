using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using ЛР_6;

namespace TestMyDeque
{
    [TestFixture]
    public class PositiveTest // позитивный тест, программа работает в штатном режиме
    {      
        [Test]
        public void AddFirstTest()
        {
            MyDeque<int> deq = new MyDeque<int>() { 5, 3 };
            int expected = 1;
            deq.AddFirst(expected);
            Assert.AreEqual(expected, deq[0]);
        }
        [Test]
        public void AddLastTest()
        {
            MyDeque<int> deq = new MyDeque<int>() { 5, 3 } ;
            int expected = 1;
            deq.Add(expected);
            Assert.AreEqual(expected, deq[deq.Lenght() - 1]);
        }
        [Test]
        public void RemoveFirsTest()
        {
            MyDeque<int> deq = new MyDeque<int>() { 5, 3 };
            int expected = 3;
            deq.Remove();
            Assert.AreEqual(expected, deq[0]);
        }
        [Test]
        public void RemoveLastTest()
        {
            MyDeque<int> deq = new MyDeque<int>() { 5, 3 };
            int expected = 5;
            deq.RemoveLast();
            Assert.AreEqual(expected, deq[0]);
        }
        [Test]
        public void ClearTest()
        {
            MyDeque<int> deq = new MyDeque<int>() { 5, 3 };
            int expected = 0;
            deq.Clear();
            foreach (int i in deq)
                Assert.AreEqual(expected, deq[i]);
        }
        [Test]
        public void RemoveAllTest()
        {
            MyDeque<int> deq = new MyDeque<int>() { 5, 3 };
            deq.RemoveAll();
            Assert.IsTrue(deq.IsEmpety());
        }
        [Test]
        public void IsEmpetyAfterCreation()
        {
            MyDeque<int> deq = new MyDeque<int>();
            Assert.IsTrue(deq.IsEmpety());
        }
        [Test]
        public void IsNotEmpetyAfterAddFirst()
        {
            MyDeque<int> deq = new MyDeque<int>();
            deq.Add(5);
            Assert.IsFalse(deq.IsEmpety());
        }
        [Test]
        public void IEnumerableTest()
        {
            MyDeque<int> deq = new MyDeque<int>() { 1, 2, 3, 4, 5 };
            string expected = " 1 2 3 4 5";
            string s = "";
            foreach (int p in deq)
                s += " " + p;
            Assert.AreEqual(expected, s);
        }
        [Test]
        public void WriteTest()
        {
            MyDeque<int> deq = new MyDeque<int>() { 1, 2, 3, 4, 5 };
            string expected = "Элементы дека: 1 2 3 4 5 ";
            Assert.AreEqual(expected, deq.Write());
        }



    }

    [TestFixture]
    public class BlackBoxTest  
    {
        // разделение на классы эквивалентности (тесты с разными ТД)
        [Test]
        public void AddFirstBool()
        {
            MyDeque<bool> deq = new MyDeque<bool>() { true, false, true };
            bool expected = false;
            deq.AddFirst(expected);
            Assert.AreEqual(expected, deq[0]);
        }
        [Test]
        public void AddFirstDouble()
        {
            MyDeque<Double> deq = new MyDeque<Double>() { 1.1, 1, 5.77 };
            Double expected = 5;
            deq.AddFirst(expected);
            Assert.AreEqual(expected, deq[0]);
        }
        [Test]
        public void AddFirstString()
        {
            MyDeque<string> deq = new MyDeque<string>() { "fff", "AAA", "DADSDADAD" };
            string expected = "w";
            deq.AddFirst(expected);
            Assert.AreEqual(expected, deq[0]);
        }


    }

    [TestFixture]
    public class WhiteBoxTest
    {
        // На основе реализации и знании алгоритма покрыть условия и операторы,
        // которые не были пройдены в позитивном тесте
        [Test]
        public void RemoveEmptyDeqExeptionTest()
        {
            MyDeque<int> deq = new MyDeque<int>();
            Assert.Throws<OverflowException>(() => deq.Remove());
        }
        [Test]
        public void RemoveLastEmptyDeqExeptionTest()
        {
            MyDeque<int> deq = new MyDeque<int>();
            Assert.Throws<OverflowException>(() => deq.RemoveLast());
        }

    }

    //public static class MyAssert
    //{
    //    public static void Throws<T>(Action func) where T : Exception
    //    {
    //        var exceptionThrown = false;
    //        try
    //        {
    //            func.Invoke();
    //        }
    //        catch (T)
    //        {
    //            exceptionThrown = true;
    //        }

    //        if (!exceptionThrown)
    //        {
    //            throw new AssertFailedException(
    //                String.Format("An exception of type {0} was expected, but not thrown", typeof(T))
    //                );
    //        }
    //    }
    //}
}
