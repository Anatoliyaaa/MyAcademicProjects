using NUnit.Framework;
using FluentAssertions;
using ËÐ_9;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
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
    }
}