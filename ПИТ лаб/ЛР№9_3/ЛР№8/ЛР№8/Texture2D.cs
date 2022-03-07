using OpenTK.Graphics.OpenGL;
using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_8
{
    class Texture2D
    {
        private int index;

        //конструктор для текстур
        public Texture2D(string path)
        {
            index = GL.GenTexture();
            //связывает текстуру
            GL.BindTexture(TextureTarget.Texture2D, index);
            // устранавливает параметры текстуры
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);

            // загружает изображение
            using (Image image = new Image(path))
            {
                // Отражает изображение по вертикали
                image.FlipVertically();
                // устанавливает размерные параметры для текстуры
                GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgb, (int)image.Size.X, (int)image.Size.Y, 0, PixelFormat.Rgba, PixelType.UnsignedByte, image.Pixels);
                GL.GenerateMipmap(GenerateMipmapTarget.Texture2D);
            }
            // очищаем буффер
            Disable();
        }

        //метод связывания текстуры
        public void Enable()
        {
            GL.BindTexture(TextureTarget.Texture2D, index);
        }

        //метод очищения текстуры
        public static void Disable()
        {
            GL.BindTexture(TextureTarget.Texture2D, 0);
        }
    }
}
