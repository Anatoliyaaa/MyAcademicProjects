using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_8
{
    class Renderer
    {
        public void Render(RenderData data, params PointerData[] pointers)
        {
            data.Shader.Activate();
            data.VBO.Enable();

            for (int i = 0; i < pointers.Length; i++)
            {
                var pointer = pointers[i];

                GL.EnableVertexAttribArray(pointer.Index);
                GL.VertexAttribPointer(pointer.Index, pointer.Count, VertexAttribPointerType.Float, false, pointer.Stride, pointer.Offset);
            }

            GL.DrawArrays(PrimitiveType.Triangles, 0, data.CountPoint);

            for (int i = 0; i < pointers.Length; i++)
                GL.DisableVertexAttribArray(pointers[i].Index);

            DataBuffer.Disable(BufferTarget.ArrayBuffer);
            ShaderProgram.Disable();
        }
    }

    struct RenderData
    {
        public DataBuffer VBO { get; private set; }

        public ShaderProgram Shader { get; private set; }

        public int CountPoint { get; private set; }

        public RenderData(DataBuffer vBO, ShaderProgram shader, int countPoint)
        {
            VBO = vBO;
            Shader = shader;
            CountPoint = countPoint;
        }
    }

    struct PointerData
    {
        public int Index { get; private set; }

        public int Count { get; private set; }

        public VertexAttribPointerType VertexType { get; private set; }

        public int Stride { get; private set; }

        public int Offset { get; private set; }

        public PointerData(int index, int count, VertexAttribPointerType vertexType, int stride, int offset)
        {
            Index = index;
            Count = count;
            VertexType = vertexType;
            Stride = stride;
            Offset = offset;
        }
    }
}
