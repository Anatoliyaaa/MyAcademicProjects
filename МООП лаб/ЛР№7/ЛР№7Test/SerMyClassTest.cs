using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ЛР_7;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;using System.IO;

namespace ЛР_7Test
{
    [TestClass]
    public class SerMyClassTest
    {
        [TestMethod]
        public void CheckBinarySerialize()
        {
            //сериализация в бинарном формате
            string expected = "5 1 9 3 7 ";
            MyDeque<int> deq = new MyDeque<int>() { 5, 1, 9,3,7 };

            MyDeque<int>.SaveDequeInBinaryFormat(deq);
            MyDeque<int> deq2 = MyDeque<int>.OpenDequeFromBinaryFormat();
            string s = "";
            foreach (int i in deq2)
            {
                s += i + " ";
            }
            Assert.AreEqual(expected, s);
        }

    }
}
