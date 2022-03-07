using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ЛР_9;

namespace CompositeTest
{
    [TestClass]
    public class HouseTest
    {
        [TestMethod]
        public void onefloor1roomTest()
        {
            Composite a = new Composite(10, 5);
            string exeption = "Этаж номер 1  | Площадь комнаты : 10 | Площадь коридора : 5\n";
            Assert.AreEqual(exeption,a.Display());
        }
        [TestMethod]
        public void onefloor2roomsTest()
        {
            Composite a = new Composite(10, 5);
            a.Add(new Leaf(5, 1));
            string exeption = "Этаж номер 1  | Площадь комнаты : 10 | Площадь коридора : 5\nЭтаж номер 1  | Площадь комнаты : 5 | Площадь коридора : 1\n";
            Assert.AreEqual(exeption, a.Display());
        }

        [TestMethod]
        public void twofloor4roomTest()
        {
            Composite a = new Composite(10, 5);
            a.Add(new Leaf(5, 1));
            Composite b = new Composite(20, 9);
            b.Add(new Leaf(11, 4));
            a.Add(b);
            string exeption = "Этаж номер 1  | Площадь комнаты : 10 | Площадь коридора : 5\nЭтаж номер 1  | Площадь комнаты : 5 | Площадь коридора : 1\nЭтаж номер 1 пройден\nЛестница\nЭтаж номер 2  | Площадь комнаты : 20 | Площадь коридора : 9\nЭтаж номер 2  | Площадь комнаты : 11 | Площадь коридора : 4\n";
            Assert.AreEqual(exeption, a.Display());
        }
        [TestMethod]
        public void SHouseTest()
        {
            Composite a = new Composite(10, 5);
            a.Add(new Leaf(5, 1));
            Composite b = new Composite(20, 9);
            b.Add(new Leaf(11, 4));
            a.Add(b);
            int exeption = 65;
            Assert.AreEqual(exeption, a.S());

        }


    }
}
