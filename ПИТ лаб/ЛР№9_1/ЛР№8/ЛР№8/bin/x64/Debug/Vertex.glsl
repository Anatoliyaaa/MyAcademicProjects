#version 440

layout(location = 0) in vec3 Pos;


out vec3 color;
out vec2 texture;


void main()
{
    gl_Position = vec4(Pos, 1.0);
}