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
        private static readonly PointerData[] pointer =
        {
            new PointerData(0, 3, VertexAttribPointerType.Float, sizeof(float) * 5, 0),
            new PointerData(1, 2, VertexAttribPointerType.Float, sizeof(float) * 5, sizeof(float) * 3)
        };

        //пространство для наложения текстуры
        private static readonly float[] quad =
        {
           -1f, 1f, 0f, 0f, 1f,
           -1f, -1f, 0f, 0f, 0f,
            1f, -1f, 0f, 1f, 0f,
           -1f, 1f, 0f, 0f, 1f,
            1f, 1f, 0f, 1f, 1f,
            1f, -1f, 0f, 1f, 0f
        };

        private static Renderer renderer = new Renderer();

        private static ShaderProgram shader;

        private static RenderWindow window;

        private static Texture2D texture1;
        private static Vector4 color1 = new Vector4(1, 1, 1, 0);//цвет (красный)

        private static void Main()
        {
            var game = new GameWindow();
            //задаем имя и разрешение окна
            window = new RenderWindow(new VideoMode(800, 600), "");
            window.Resized += OnResize;
            window.Closed += OnClose;

            // создание шейдеров для текстуры
            shader = new ShaderProgram(new ShaderData("Vertex.glsl", ShaderType.VertexShader), new ShaderData("Fragment.glsl", ShaderType.FragmentShader));
            // шейдер для заливки цветом
            shader.SetVector4(color1, "color");

            //буфер данных
            DataBuffer vbo = new DataBuffer(BufferTarget.ArrayBuffer);
            vbo.SetData(sizeof(float) * quad.Length, quad);

            //создание текстуры (присваивается изображение из папки проекта)
            texture1 = new Texture2D("Image.jpg");

            //Выполнение действий, пока окно открыто
            while (window.IsOpen == true)
            {
                window.DispatchEvents();

                //очищение
                GL.Clear(ClearBufferMask.ColorBufferBit);

                if (Keyboard.IsKeyPressed(Keyboard.Key.Q))
                {
                    color1 = new Vector4(1, 0, 0, 1);
                    shader.SetVector4(color1, "color");
                }
                if (Keyboard.IsKeyPressed(Keyboard.Key.E))
                {
                    color1 = new Vector4(1, 1, 1, 0);
                    shader.SetVector4(color1, "color");
                }
                //наложение текстуры
                texture1.Enable();
                //рендер шейдеров для текстуры
                renderer.Render(new RenderData(vbo, shader, 6), pointer);

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
