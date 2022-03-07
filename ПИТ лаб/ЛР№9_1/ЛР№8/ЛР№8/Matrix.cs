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
    struct Matrix4
    {
        public Vector4 Colum1;
        public Vector4 Colum2;
        public Vector4 Colum3;
        public Vector4 Colum4;

        public Matrix4(Vector4 colum1, Vector4 colum2, Vector4 colum3, Vector4 colum4)
        {
            Colum1 = colum1;
            Colum2 = colum2;
            Colum3 = colum3;
            Colum4 = colum4;
        }
        
        public static Matrix4 operator *(Matrix4 Mat1, Matrix4 Mat2)
        {
            Matrix4 Res = new Matrix4();

            Res.Colum1.X = (Mat1.Colum1.X * Mat2.Colum1.X) + (Mat1.Colum1.Y * Mat2.Colum2.X) + (Mat1.Colum1.Z * Mat2.Colum3.X) + (Mat1.Colum1.W * Mat2.Colum4.X);
            Res.Colum1.Y = (Mat1.Colum1.X * Mat2.Colum1.Y) + (Mat1.Colum1.Y * Mat2.Colum2.Y) + (Mat1.Colum1.Z * Mat2.Colum3.Y) + (Mat1.Colum1.W * Mat2.Colum4.Y);
            Res.Colum1.Z = (Mat1.Colum1.X * Mat2.Colum1.Z) + (Mat1.Colum1.Y * Mat2.Colum2.Z) + (Mat1.Colum1.Z * Mat2.Colum3.Z) + (Mat1.Colum1.W * Mat2.Colum4.Z);
            Res.Colum1.W = (Mat1.Colum1.X * Mat2.Colum1.W) + (Mat1.Colum1.Y * Mat2.Colum2.W) + (Mat1.Colum1.Z * Mat2.Colum3.W) + (Mat1.Colum1.W * Mat2.Colum4.W);

            Res.Colum2.X = (Mat1.Colum2.X * Mat2.Colum1.X) + (Mat1.Colum2.Y * Mat2.Colum2.X) + (Mat1.Colum2.Z * Mat2.Colum3.X) + (Mat1.Colum2.W * Mat2.Colum4.X);
            Res.Colum2.Y = (Mat1.Colum2.X * Mat2.Colum1.Y) + (Mat1.Colum2.Y * Mat2.Colum2.Y) + (Mat1.Colum2.Z * Mat2.Colum3.Y) + (Mat1.Colum2.W * Mat2.Colum4.Y);
            Res.Colum2.Z = (Mat1.Colum2.X * Mat2.Colum1.Z) + (Mat1.Colum2.Y * Mat2.Colum2.Z) + (Mat1.Colum2.Z * Mat2.Colum3.Z) + (Mat1.Colum2.W * Mat2.Colum4.Z);
            Res.Colum2.W = (Mat1.Colum2.X * Mat2.Colum1.W) + (Mat1.Colum2.Y * Mat2.Colum2.W) + (Mat1.Colum2.Z * Mat2.Colum3.W) + (Mat1.Colum2.W * Mat2.Colum4.W);

            Res.Colum3.X = (Mat1.Colum3.X * Mat2.Colum1.X) + (Mat1.Colum3.Y * Mat2.Colum2.X) + (Mat1.Colum3.Z * Mat2.Colum3.X) + (Mat1.Colum3.W * Mat2.Colum4.X);
            Res.Colum3.Y = (Mat1.Colum3.X * Mat2.Colum1.Y) + (Mat1.Colum3.Y * Mat2.Colum2.Y) + (Mat1.Colum3.Z * Mat2.Colum3.Y) + (Mat1.Colum3.W * Mat2.Colum4.Y);
            Res.Colum3.Z = (Mat1.Colum3.X * Mat2.Colum1.Z) + (Mat1.Colum3.Y * Mat2.Colum2.Z) + (Mat1.Colum3.Z * Mat2.Colum3.Z) + (Mat1.Colum3.W * Mat2.Colum4.Z);
            Res.Colum3.W = (Mat1.Colum3.X * Mat2.Colum1.W) + (Mat1.Colum3.Y * Mat2.Colum2.W) + (Mat1.Colum3.Z * Mat2.Colum3.W) + (Mat1.Colum3.W * Mat2.Colum4.W);

            Res.Colum4.X = (Mat1.Colum4.X * Mat2.Colum1.X) + (Mat1.Colum4.Y * Mat2.Colum2.X) + (Mat1.Colum4.Z * Mat2.Colum3.X) + (Mat1.Colum4.W * Mat2.Colum4.X);
            Res.Colum4.Y = (Mat1.Colum4.X * Mat2.Colum1.Y) + (Mat1.Colum4.Y * Mat2.Colum2.Y) + (Mat1.Colum4.Z * Mat2.Colum3.Y) + (Mat1.Colum4.W * Mat2.Colum4.Y);
            Res.Colum4.Z = (Mat1.Colum4.X * Mat2.Colum1.Z) + (Mat1.Colum4.Y * Mat2.Colum2.Z) + (Mat1.Colum4.Z * Mat2.Colum3.Z) + (Mat1.Colum4.W * Mat2.Colum4.Z);
            Res.Colum4.W = (Mat1.Colum4.X * Mat2.Colum1.W) + (Mat1.Colum4.Y * Mat2.Colum2.W) + (Mat1.Colum4.Z * Mat2.Colum3.W) + (Mat1.Colum4.W * Mat2.Colum4.W);

            return Res;

        }

        public override string ToString()
        {
            return $"{Colum1}  \n{Colum2} \n{Colum3} \n{Colum4}";
        }

        public void Translate(Vector3f Pos)
        {
            Colum1.X = 1;
            Colum2.Y = 1;
            Colum3.Z = 1;
            Colum4.W = 1;

            Colum1.W = Pos.X;
            Colum2.W = Pos.Y;
            Colum3.W = Pos.Z;

        }

        public void Scale(Vector3f Scale)
        {
            Colum1.X = Scale.X;
            Colum2.Y = Scale.Y;
            Colum3.Z = Scale.Z;
            Colum4.W = 1;
        }

        public void Rotation(Vector3f Rot)
        {
            Matrix4 matX = new Matrix4();
            Matrix4 matY = new Matrix4();
            Matrix4 matZ = new Matrix4();

            //MatX
            matX.Colum1.X = 1;
            matX.Colum4.W = 1;

            matX.Colum2.Y = (float)Math.Cos(Rot.X);
            matX.Colum2.Z = -(float)Math.Sin(Rot.X);

            matX.Colum3.Y = (float)Math.Sin(Rot.X);
            matX.Colum3.Y = (float)Math.Cos(Rot.X);

            //MatY
            matX.Colum1.Y = 1;
            matX.Colum4.W = 1;

            matX.Colum1.X = (float)Math.Cos(Rot.Y);
            matX.Colum1.Z = -(float)Math.Sin(Rot.Y);

            matX.Colum3.X = (float)Math.Sin(Rot.Y);
            matX.Colum3.Z = (float)Math.Cos(Rot.Y);


            //MatZ
            matX.Colum3.Z = 1;
            matX.Colum4.W = 1;

            matX.Colum1.X = (float)Math.Cos(Rot.Z);
            matX.Colum1.Y = -(float)Math.Sin(Rot.Z);

            matX.Colum2.X = (float)Math.Sin(Rot.Z);
            matX.Colum2.Y = (float)Math.Cos(Rot.Z);

            Matrix4 res = matX * matY * matZ;

            Colum1 = res.Colum1;
            Colum2 = res.Colum2;
            Colum3 = res.Colum3;
            Colum4 = res.Colum4;






        }

        public float[] GetArray()
        {
            float[] array =
            {
                Colum1.X,Colum1.Y,Colum1.Z,Colum1.W,
                Colum2.X,Colum2.Y,Colum2.Z,Colum2.W,
                Colum3.X,Colum3.Y,Colum3.Z,Colum3.W,
                Colum4.X,Colum4.Y,Colum4.Z,Colum4.W,
            };
            return array;
                
        }
    }

    struct Vector4
    {
        public float X;
        public float Y;
        public float Z;
        public float W;

        public Vector4(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public override string ToString()
        {
            return "{" + $"{X},{Y},{Z},{W}"+ "}";
        }

    }


}
