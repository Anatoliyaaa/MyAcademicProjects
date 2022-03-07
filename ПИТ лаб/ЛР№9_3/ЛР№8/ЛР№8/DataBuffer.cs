using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_8
{
    class DataBuffer : IDisposable
    {
        private int index;
        private BufferTarget target;

        public DataBuffer(BufferTarget target)
        {
            index = GL.GenBuffer();
            this.target = target;          
        }

        ~DataBuffer()
        {
            Dispose();
        }

        public void Enable()
        {
            GL.BindBuffer(target, index);
        }

        public void SetData<T>(int size, T[] data) where T : struct
        {
            Enable();
            GL.BufferData(target, size, data, BufferUsageHint.StaticDraw);
            Disable(target);
        }

        public static void Disable(BufferTarget target)
        {
            GL.BindBuffer(target, 0);
        }

        public void Dispose()
        {
           // GL.DeleteBuffer(index);
        }
    }
}
