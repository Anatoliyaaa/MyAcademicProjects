using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using SFML.System;
using SFML.Graphics;
using SFML.Window;
using System.IO;
//using OpenTK.Input;
using System.Windows.Input;

namespace ЛР_8
{

    class Program
    {

        static int program;
        static RenderWindow window;
        static void Main(string[] args)
        {

            var gw = new GameWindow();


            window = new RenderWindow(new VideoMode(800, 600), "212"); //создание окна 

            window.Closed += (obj, e) => { window.Close(); }; //обработка закрытия
            //обработка изменения окна
            window.Resized += (obj, e) => { window.SetView(new View(new FloatRect(0, 0, e.Width, e.Height))); GL.Viewport(0, 0, (int)e.Width, (int)e.Height); };


            window.SetActive(true);//активация окна


            GL.Viewport(0, 0, (int)window.Size.X, (int)window.Size.Y); // размер окна

            // загрузка шейдеров в программу
            program = LoadShaders();

            VertexBuffer vertex = new VertexBuffer(); // список вершин
            vertex.AddVertex(new Vector3f(0, (float)0.1, 0), new Vector3f(1, 0, 0), new Vector2f()); //параметры вершины ( координаты Х, Y, Z; цвет R, G, B; текстура)
            vertex.AddVertex(new Vector3f(-(float)0.1, 0, 0), new Vector3f(0, 1, 0), new Vector2f());
            vertex.AddVertex(new Vector3f((float)0.1, 0, 0), new Vector3f(0, 0, 1), new Vector2f());


            Transforms3D transform = new Transforms3D(); // объект класса для трансформации вершин
            



            int VBO = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, VBO);
            GL.BufferData(BufferTarget.ArrayBuffer, vertex.GetMemory(), vertex.GetData(), BufferUsageHint.StaticDraw);


            int index = GL.GetUniformLocation(program, "WorldMat");

            float scale = 1;
            float rotat = 0;

            //Выполнение действий, пока окно открыто
            while (window.IsOpen)
            {

                window.DispatchEvents();

                GL.Clear(ClearBufferMask.ColorBufferBit);

                //поворот вправо
                if (Keyboard.IsKeyPressed(Keyboard.Key.Right))
                {
                    rotat = rotat - 0.001f;
                    transform.Rotation = new Vector3f(0, 0, rotat);
                }

                //поворот влево 
                if (Keyboard.IsKeyPressed(Keyboard.Key.Left))
                {
                    rotat = rotat + 0.001f;
                    transform.Rotation = new Vector3f(0, 0, rotat);
                }

                //масштабирование (увеличение на 1%)
                if (Keyboard.IsKeyPressed(Keyboard.Key.Up))
                {
                    scale = scale + 0.001f;
                    transform.Scale = new Vector3f(scale, scale, scale);
                }

                //масштабирование (уменьшение на 1%)
                if (Keyboard.IsKeyPressed(Keyboard.Key.Down))
                {
                    scale = scale - 0.001f;
                    transform.Scale = new Vector3f(scale, scale, scale);
                }


                GL.UseProgram(program);

                Matrix4 matrix = transform.GetMatrix();//обновление шейдеров по глобальной матрице


                GL.UniformMatrix4(index, 1, true, matrix.GetArray());


                GL.BindBuffer(BufferTarget.ArrayBuffer, VBO);

                GL.EnableVertexAttribArray(0);
                GL.EnableVertexAttribArray(1);
                GL.EnableVertexAttribArray(2);


                //000 000 00;

                GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, Vertex.GetMemory(), 0);
                GL.VertexAttribPointer(1, 3, VertexAttribPointerType.Float, false, Vertex.GetMemory(), sizeof(float) * 3);
                GL.VertexAttribPointer(2, 2, VertexAttribPointerType.Float, false, Vertex.GetMemory(), sizeof(float) * 6);


                  


                GL.DrawArrays(OpenTK.Graphics.OpenGL.PrimitiveType.Triangles, 0, 3);


                GL.DisableVertexAttribArray(0);
                GL.DisableVertexAttribArray(1);
                GL.DisableVertexAttribArray(2);


                GL.UseProgram(0);


                window.Display();
            }
            
            





        }

        // загрузка шейдеров
        static int LoadShaders()
        {
            //создается вершинный шейдер
            int Ver = GL.CreateShader(ShaderType.VertexShader);
            //создается фрагментный шейдер
            int Fra = GL.CreateShader(ShaderType.FragmentShader);

            // обработка ошибок с вершинным шейдером
            string Source = File.ReadAllText("Vertex.glsl");

            GL.ShaderSource(Ver, Source);
            GL.CompileShader(Ver);

            int Status;
            GL.GetShader(Ver, ShaderParameter.CompileStatus, out Status);
             
            if (Status == 0)
            {
                string info;
                GL.GetShaderInfoLog(Ver, out info);
                Console.WriteLine("Error VSH {0}", info);
                

            }


            //обработка ошибок с фрагментным шейдером
            Source = File.ReadAllText("Fragment.glsl");

            GL.ShaderSource(Fra, Source);
            GL.CompileShader(Fra);

            GL.GetShader(Fra, ShaderParameter.CompileStatus, out Status);

            if (Status == 0)
            {
                string info;
                GL.GetShaderInfoLog(Fra, out info);
                Console.WriteLine("Error VSH {0}", info);
               


            }

            //

            int program = GL.CreateProgram();

            //присоединяет шейдеры к объекту
            GL.AttachShader(program, Ver);
            GL.AttachShader(program, Fra);

            GL.LinkProgram(program);

            //обработка ошибок при запуске программы
            GL.GetProgram(program, GetProgramParameterName.LinkStatus,out Status);

            if (Status == 0)
            {
                string info;
                GL.GetProgramInfoLog(program, out info);
                Console.WriteLine("Error VSH {0}", info);
           

            }


            GL.UseProgram(0);

            GL.DeleteShader(Ver);
            GL.DeleteShader(Fra);


            return program;
        }
    }


}
