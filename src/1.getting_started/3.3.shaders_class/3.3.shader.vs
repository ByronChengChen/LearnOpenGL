#version 330 core
layout (location = 0) in vec3 aPos;
layout (location = 2) in vec3 aColor;

out vec3 ourColor;
uniform float uRight;
void main()
{
    gl_Position = vec4(aPos.x+uRight,aPos.y,aPos.z,1.0);
    ourColor = aColor;
}
