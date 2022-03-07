using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using ЛР_8;

namespace MyTestSubstitute
{
    [TestClass]
    public class TestGraph
    {
        [TestMethod]
        public void TestMethod1()
        {
            IReader read = Substitute.For<IReader>();
            IWriter write = Substitute.For<IWriter>();

            read.GetMatrixIncend().Returns(
                new int[,] { { 0, 1, 0, 0, 1, 0},
                                { 1, 0, 1, 0, 1, 0},
                                { 0, 1, 0, 1, 0, 0},
                                { 0, 0, 1, 0, 1, 1},
                                { 1, 1, 0, 1, 0, 0},
                                { 0, 0, 0, 1, 0, 0} });

            int[,] expected = { { 0, 1, 0, 0, 1, 0},
            { 1, 0, 1, 0, 1, 0},
            { 0, 1, 0, 1, 0, 0},
            { 0, 0, 1, 0, 1, 1},
            { 1, 1, 0, 1, 0, 0},
            { 0, 0, 0, 1, 0, 0} };

            Graph graph = new Graph(read, write);
            graph.GetMartixFromFile();
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    Assert.AreEqual(expected[i, j], graph.matrix[i, j]);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //обход графа в ширину
            IReader read = Substitute.For<IReader>();
            IWriter write = Substitute.For<IWriter>();
            read.GetMatrixIncend().Returns(
                new int[,] { { 0, 1, 0, 0, 1, 0},
                                { 1, 0, 1, 0, 1, 0},
                                { 0, 1, 0, 1, 0, 0},
                                { 0, 0, 1, 0, 1, 1},
                                { 1, 1, 0, 1, 0, 0},
                                { 0, 0, 0, 1, 0, 0} });

            bool[] expected = { true, true, true, true, true, true };
            Graph graph = new Graph(read, write);
            graph.GetMartixFromFile();

            bool[] visited = graph.BFS(0);
            for (int i = 0; i < 6; i++)
                Assert.AreEqual(expected[i], visited[i]);


        }

    }
}
