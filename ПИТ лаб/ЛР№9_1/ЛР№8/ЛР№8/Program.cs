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

namespace ЛР_8
{
    class Program
    {
        private static readonly PointerData pointer = new PointerData(0, 3, VertexAttribPointerType.Float, 0, 0);

        //первый треугольник
        private static readonly float[] triangle =
        {
            -.25f, 1f, 0f,
            -.5f, 0f, 0f,
            -0.1f, 0f, 0f
        };
        //второй треугольник
        private static readonly float[] triangle2 =
        {
            .25f, 1f, 0f,
            .5f, 0f, 0f,
            0.1f, 0f, 0f
        };

        private static Renderer renderer = new Renderer();

        private static ShaderProgram shader1;
        private static ShaderProgram shader2;

        private static RenderWindow window;

        private static Vector4 color1 = new Vector4(1, 0, 1, 1);//цвет первого треугольника
        private static Vector4 color2 = new Vector4(0, 1, 0, 1);//цвет второго треугольника

        private static Vector4 color3 = new Vector4(1, 0, 0, 1);//цвет для заливки штриховкой
        private static Vector4 color4 = new Vector4(0, 1, 1, 1);//цвет для заливки штриховкой

        private static void Main()
        {
            var game = new GameWindow();
            //задаем имя и разрешение окна
            window = new RenderWindow(new VideoMode(800, 600), "");
            window.Resized += OnResize;
            window.Closed += OnClose;
            // создание разных шейдеров для каждого треугольника
            shader1 = new ShaderProgram(new ShaderData("Vertex.glsl", ShaderType.VertexShader), new ShaderData("Fragment.glsl", ShaderType.FragmentShader));
            shader2 = new ShaderProgram(new ShaderData("Vertex.glsl", ShaderType.VertexShader), new ShaderData("Fragment2.glsl", ShaderType.FragmentShader));
            // передаем цвет для заливок (одноцветной и штриховкой)
            shader1.SetVector4(color1, "color");
            shader2.SetVector4(color2, "color");

            //буфер данных для первого треугольника
            DataBuffer vbo1 = new DataBuffer(BufferTarget.ArrayBuffer);
            vbo1.SetData(sizeof(float) * triangle.Length, triangle);
            //буфер данных для второго треугольника
            DataBuffer vbo2 = new DataBuffer(BufferTarget.ArrayBuffer);
            vbo2.SetData(sizeof(float) * triangle2.Length, triangle2);


            //Выполнение действий, пока окно открыто
            while (window.IsOpen == true)
            {
                window.DispatchEvents();
                //очищение
                GL.Clear(ClearBufferMask.ColorBufferBit);

                if (Keyboard.IsKeyPressed(Keyboard.Key.Q))
                    shader1.SetVector4(color3, "color");

                if (Keyboard.IsKeyPressed(Keyboard.Key.E))
                    shader2.SetVector4(color4, "color");

                if (Keyboard.IsKeyPressed(Keyboard.Key.A))
                    shader1.SetVector4(color1, "color");

                if (Keyboard.IsKeyPressed(Keyboard.Key.D))
                    shader2.SetVector4(color2, "color");

                //рендер шейдеров для треугольниковы
                renderer.Render(new RenderData(vbo1, shader1, 3), pointer);
                renderer.Render(new RenderData(vbo2, shader2, 3), pointer);

                window.Display();
            }
        }

        //изменение размера окна
        private static void OnResize(object o, SizeEventArgs e)
        {
            GL.Viewport(0, 0, (int)e.Width, (int)e.Height);
            window.SetView(new View(new FloatRect(0, 0, e.Width, e.Height)));
        }

        //закрытие окна
        private static void OnClose(object o, EventArgs e)
        {
            window.Close();
        }
    }
}
