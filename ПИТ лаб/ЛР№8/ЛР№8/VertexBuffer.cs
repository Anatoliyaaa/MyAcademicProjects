using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.System;

namespace ЛР_8
{
    class VertexBuffer
    {
        List<Vertex> vertices;
        // список вершин
        public VertexBuffer()
        {
            vertices = new List<Vertex>();
        }

        //добавление новой вершины
        public void AddVertex( Vertex vertex)
        {
            vertices.Add(vertex);
        }
        //добавление новой вершины (перегрузка)
        public void AddVertex(Vector3f Pos, Vector3f Col, Vector2f Tex)
        {
            vertices.Add(new Vertex(Pos, Col, Tex));
        } 

        // возвращение занимаемой памяти
        public int GetMemory()
        {
             
            return Vertex.GetMemory() * vertices.Count;

        }

        // возвращение данных списка всех вершин
        public float [] GetData()
        {
            List<float> data = new List<float>();


            for (int i = 0; i< vertices.Count; i++)
            {
                data.AddRange(vertices[i].GetData());
            }

            return data.ToArray();
        }
    }

    // класс вершин
    class Vertex
    {
        public Vector3f Pos;//вектор позиции (X, Y, Z)
        public Vector3f Col;//вектор цвета (R, G, B)
        public Vector2f Tex;//вектор текстур

        // конструктор вершин
        public Vertex( Vector3f Pos, Vector3f Col, Vector2f Tex)
        {

            this.Pos = Pos;
            this.Col = Col;
            this.Tex = Tex;

        }

        // возвращает данные вершины
        public float [] GetData()
        {
            float[] data = new float[8]
            {
                Pos.X, Pos.Y,Pos.Z,
                Col.X, Col.Y, Col.Z,
                Tex.X, Tex.Y
            };

            return data;

        }

        // возвращает занимаемую память
        public static int GetMemory()
        {
            return sizeof(float) * 8;
        }

    }
}
