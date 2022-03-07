using OpenTK.Graphics.OpenGL;
using SFML.System;
using System;
using System.IO;

namespace ЛР_8
{
    class ShaderProgram : IDisposable
    {
        private int index;

        public ShaderProgram(params ShaderData[] shaders)
        {
            index = GL.CreateProgram();

            foreach (var shader in shaders)
                RegisterShader(shader);

            GL.LinkProgram(index);
            GL.GetProgram(index, GetProgramParameterName.LinkStatus, out int status);

            if(status == 0)
            {
                string message = GL.GetProgramInfoLog(index);
                throw new Exception(message);
            }
        }

        public void Activate()
        {
            GL.UseProgram(index);
        }

        public void SetVector3(Vector3f value, string name)
        {
            int location = GL.GetUniformLocation(index, name);
            GL.Uniform3(location, value.X, value.Y, value.Z);
        }

        public void SetVector4(Vector4 value, string name)
        {
            Activate();

            int location = GL.GetUniformLocation(index, name);
            GL.Uniform4(location, value.X, value.Y, value.Z, value.W);

            Disable();
        }

        public static void Disable()
        {
            GL.UseProgram(0);
        }

        public void Dispose()
        {
            GL.DeleteProgram(index);
        }

        private void RegisterShader(ShaderData Data)
        {
            int shaderIndex = GL.CreateShader(Data.Type);
            GL.ShaderSource(shaderIndex, File.ReadAllText(Data.Path));
            GL.CompileShader(shaderIndex);

            GL.GetShader(shaderIndex, ShaderParameter.CompileStatus, out int status);

            if(status == 0)
            {
                string message = GL.GetShaderInfoLog(shaderIndex);
                throw new Exception(message);
            }

            GL.AttachShader(index, shaderIndex);
            GL.DeleteShader(shaderIndex);
        }
    }

    struct ShaderData
    {
        public string Path { get; private set; }

        public ShaderType Type { get; private set; }

        public ShaderData(string path, ShaderType type)
        {
            Path = path;
            Type = type;
        }
    }
}