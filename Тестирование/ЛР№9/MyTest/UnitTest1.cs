using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using FluentAssertions;
using System.Collections.Generic;
using System.IO;
using ЛР_9;

namespace MyTest
{
    [TestFixture]
    public class UnitTest1
    {


        [Test()]
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

        }

        [Test()]
        public void SaveClass_Test()
        {
            List<Edge> list = new List<Edge>();
            list.Add(new Edge(0, 1));
            list.Add(new Edge(0, 4));
            list.Add(new Edge(1, 4));
            list.Add(new Edge(1, 2));
            list.Add(new Edge(2, 3));
            list.Add(new Edge(3, 4));
            list.Add(new Edge(3, 5));

            StringWriter stringWriter = new StringWriter();
            WriteFile fileWriter = new WriteFile(stringWriter);
            fileWriter.SaveEdges(list);
            stringWriter.ToString().Should().Be("0 1 0 4 1 4 1 2 2 3 3 4 3 5 ");
        }
        [Test()]
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



        }
    }
}
