#version 440

in vec2 texCoord;

out vec4 Col;

uniform vec4 color;
uniform sampler2D tex;

void main()
{
    Col = texture(tex, texCoord) * color;
}