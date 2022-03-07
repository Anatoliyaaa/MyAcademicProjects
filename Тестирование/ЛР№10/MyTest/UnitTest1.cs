using NUnit.Framework;
using System;
using ËÐ_10;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(-1.0, 1.0, 50, 1.2245358177778973)]
        [TestCase(-1.0, 1.0, 10, 1.2223313536666438)]
        [TestCase(-1.0, 1.0, 100, 1.2246050319733841)]
        public void TestIntegral(double a, double b, int n, double expected)
        {
            Func f = new Func(Program.function);
            double integr = Program.Trapec(f, a, b, n);
            Assert.AreEqual(expected,integr);
        }
        [TestCase(1, 1)]
        [TestCase(0, 1)] 
        [TestCase(6, 720)] 
        public void TestFact(int n, int expected)
        {
            int x = Program.factorial(n);
            Assert.AreEqual(expected, x);
        }

        [TestCase(-7)]
        [TestCase(-1)] 
        public void TestFactLessZero(int n)
        {
            Assert.Throws<OverflowException>(() => { Program.factorial(n); });
        }


    }
}