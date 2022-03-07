using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ЛР_9;
using FluentAssertions;
using System.Xml.Linq;
using System.Data;
using System.IO;

namespace MyTestGraph
{
    [TestClass]
    public class UnitTest1
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

            graph.matrix.Should().Equals(new int[6, 6]  { { 0, 1, 0, 0, 1, 0},
            { 1, 0, 1, 0, 1, 0},
            { 0, 1, 0, 1, 0, 0},
            { 0, 0, 1, 0, 1, 1},
            { 1, 1, 0, 1, 0, 0},
            { 0, 0, 0, 1, 0, 0}});

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
            foreach (bool b in visited)
            {
                b.Should().BeTrue();
            }

            //for (int i = 0; i < 6; i++)
            //    Assert.AreEqual(expected[i], visited[i]);


        }
    }
}
