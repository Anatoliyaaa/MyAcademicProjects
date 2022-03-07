using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ЛР_7;

namespace MyGraphTest
{
    [TestClass]
    public class TestGraph
    {
        [TestMethod]
        public void TestMethod1()
        {
            IReader read = new ReaderStub();
            IWriter write = new WriterStub();
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
                    Assert.AreEqual(expected[i,j], graph.matrix[i,j]);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //обход графа в ширину
            IReader read = new ReaderStub();
            IWriter write = new WriterStub();

            bool[] expected = { true, true, true, true, true, true };
            Graph graph = new Graph(read, write);
            graph.GetMartixFromFile();

            bool[] visited = graph.BFS(0);
            for (int i = 0; i < 6; i++)
                Assert.AreEqual(expected[i], visited[i]);


        }

    }


}
