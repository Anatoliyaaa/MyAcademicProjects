using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ЛР_7;

namespace MyGraphTest
{
    public class WriterStub : IWriter // заглушка для записи
                                      // записывает список связей 
    {
        public string file;

        public void SaveEdges(List<Edge> list)
        {
            string str = "";
            foreach (Edge edge in list)
            {
                str += edge.v1 + " " + edge.v2 + " ";
            }

            file = str;

        }
    }
    public class ReaderStub : IReader // заглушка для чтения файла
    {
        public int[,] GetMatrixIncend()
        {
            int[,] matrix = { { 0, 1, 0, 0, 1, 0},
                                { 1, 0, 1, 0, 1, 0},
                                { 0, 1, 0, 1, 0, 0},
                                { 0, 0, 1, 0, 1, 1},
                                { 1, 1, 0, 1, 0, 0},
                                { 0, 0, 0, 1, 0, 0} };
            return matrix;
        }
    }
}
