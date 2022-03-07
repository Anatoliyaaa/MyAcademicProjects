using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ЛР_9
{
    public class Edge
    {
        public int v1 { get; set; }
        public int v2 { get; set; }
        public Edge(int V1, int V2)
        {
            v1 = V1;
            v2 = V2;
        }
    }
    public interface IGraph
    {
        void SaveMatrixToFile();

    }
    public interface IReader
    {
        int[,] GetMatrixIncend();
    }

    public interface IWriter
    {
        void SaveEdges(List<Edge> list);
    }

    public class Graph : IGraph
    {
        public int[,] matrix { get; set; }
        public IReader readFrom { get; set; }
        public IWriter writeTo { get; set; }
        public Graph(IReader reader, IWriter writer)
        {
            matrix = new int[0, 0];
            readFrom = reader;
            writeTo = writer;

        }

        public void GetMartixFromFile()
        {
            matrix = readFrom.GetMatrixIncend();
        }
        public void SaveMatrixToFile()
        {
            int n = matrix.GetLength(0);
            List<Edge> list = new List<Edge>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 1) list.Add(new Edge(i, j));
                }
            }
            writeTo.SaveEdges(list);
        }
        public bool[] BFS(int start_node)
        {
            bool[] visited = new bool[matrix.GetLength(0)];
            Queue<int> que_visited = new Queue<int>();
            //изначально - все вершины не посещены
            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = false;
            }
            //добавление первой вершины
            que_visited.Enqueue(start_node);
            visited[start_node] = true; //первая вершина посещена
            while (que_visited.Count != 0)
            {
                int current_vert = que_visited.Dequeue();
                List<int> child_ver = new List<int>();
                //получение смежных вершин
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[current_vert, i] == 1) child_ver.Add(i);
                }

                foreach (int v in child_ver)
                {
                    if (visited[v] == false)
                    {
                        que_visited.Enqueue(v);
                        visited[v] = true;
                    }
                }
            }
            return visited;
        }
    }
    public class ReadFile : IReader
    {
        TextReader reader;
        public ReadFile(TextReader reader)
        {
            this.reader = reader;
        }
        public int[,] GetMatrixIncend()
        {
            string str = reader.ReadToEnd();
            reader.Close(); //закрываем поток

            List<Edge> edges = new List<Edge>();
            int max_ver = -1;
            int current_sumbol = -1;
            while (current_sumbol < str.Length)
            {
                List<int> vertexes = new List<int>();

                //считываем два числа и добавляем ребро в список
                for (int i = 0; i < 2; i++)
                {
                    string current_number = "";
                    current_sumbol++;

                    try
                    {
                        while (str[current_sumbol].ToString() != " ")
                        {
                            current_number += Convert.ToInt32(Convert.ToString(str[current_sumbol++])).ToString();
                            if (Convert.ToInt32(current_number) > max_ver) max_ver = Convert.ToInt32(current_number);
                        }
                    }
                    catch { }
                    if (current_number != "") vertexes.Add(Convert.ToInt32(current_number));
                }
                if (vertexes.Count == 2)
                {
                    Edge edge = new Edge(vertexes[0], vertexes[1]);
                    edges.Add(edge);
                }
            }
            int kol_edges = edges.Count;

            int[,] matr_incend = new int[kol_edges, max_ver + 1];
            int k = 0;
            foreach (Edge e in edges)
            {
                matr_incend[k, e.v1] = 1;
                matr_incend[k, e.v2] = 1;
                k++;
            }

            return matr_incend;
        }
    }

    public class WriteFile : IWriter // Метод для записи в файл
    {
        TextWriter writer;
        public WriteFile(TextWriter writer)
        {
            this.writer = writer;
        }
        public void SaveEdges(List<Edge> list)
        {
            string str = "";
            foreach (Edge edge in list)
            {
                str += edge.v1 + " " + edge.v2 + " ";
            }

            writer.Write(str); //записываем в файл
            writer.Close(); //закрываем поток
        }
    }
}
