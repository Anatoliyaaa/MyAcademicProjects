using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace ЛР_8
{
    class Transforms3D
    {
        public Vector3f Position;//вектор позиции 
        public Vector3f Scale;// вектор масштабирвоания
        public Vector3f Rotation;//вектор вращения

        public Transforms3D (Vector3f position, Vector3f scale, Vector3f rotation)
        {
            Position = position;
            Scale = scale;
            Rotation = rotation;
        }

        public Transforms3D()
        {
            Position =new Vector3f();
            Scale = new Vector3f(1,1,1);
            Rotation = new Vector3f();
        }

        // возвращает новую матрицу, после операций над ней
        public Matrix4 GetMatrix()
        {
            Matrix4 Scl = new Matrix4();
            Matrix4 Pos = new Matrix4();
            Matrix4 Rot = new Matrix4();

            Pos.Translate(Position);
            Scl.Scale(Scale);
            Rot.Rotation(Rotation);

            return Pos * Rot * Scl;
        }
    }
}
