#version 440

in vec2 texCoord;

out vec4 Col;


uniform sampler2D tex1;
uniform sampler2D tex2;

uniform float coef;

void main()
{
    Col = mix(texture(tex1, texCoord), texture(tex2, texCoord), coef);
}