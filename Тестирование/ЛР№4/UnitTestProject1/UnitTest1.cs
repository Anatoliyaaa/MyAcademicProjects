using System;
using NUnit.Framework;
using ЛР_4;

namespace UnitTestProject1
{
    [TestFixture]
    public class CheckerTests
    {
        [TestCase(true, 0, 0)]//1
        [TestCase(true, 5, 1)]
        [TestCase(true, 4, 2)]
        [TestCase(true, 6, 2)]
        [TestCase(true, 5, 5)]
        [TestCase(false, 5, 6)]
        [TestCase(false, 1, 5)]
        [TestCase(false, -1, 1)]//2
        [TestCase(false, -10, 1)]
        [TestCase(false, -5, 10)]
        [TestCase(true, 0, -1)]//3
        [TestCase(true, -5, 0)]
        [TestCase(false, -10, 0)]
        [TestCase(false, -5, -5)]
        [TestCase(false, 1, -1)]//4
        [TestCase(false, 10, -1)]
        [TestCase(false, 10, -10)]
        [TestCase(false, 0, 5)]//1_2
        [TestCase(false, 0, 1)]
        [TestCase(true, -1, 0)]//2_3
        [TestCase(false, -10, 0)]
        [TestCase(true, 0, -5)]//3_4
        [TestCase(false, 0, -10)]
        [TestCase(true, 5, 0)]//4_1
        [TestCase(false, 11, 0)]
        [TestCase(true, 0, 0)] //zero
        public void FFTest(bool t, int x, int y)
        {
            FF ff = new FF();
            Assert.AreEqual(t, ff.HitCheck(x, y));
        }

        const string S1 = "66";
        const string S2 = "0";
        const string S = "566787665";

        [TestCase(S1, S2, S, "5078705")]
        [TestCase("9", S2, S, "566787665")]
        [TestCase("", S2, S, "566787665")]
        [TestCase(S1, "", S, "57875")]
        [TestCase(S1, S2, "", "")]
        public void GGtest(string s1, string s2, string s, string t)
        {
            GG gg = new GG();
            Assert.AreEqual(GG.ChangeStrInStr(s1, s2, s), t);
        }

    }
}
