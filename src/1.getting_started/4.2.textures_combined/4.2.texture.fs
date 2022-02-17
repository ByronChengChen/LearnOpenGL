#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;
//!!!: ck info 纹理使用 2. GLSL中定义纹理采样器
// texture samplers
uniform sampler2D samplerTexture1;
uniform sampler2D samplerTexture2;

void main()
{
	// linearly interpolate between both textures (80% container, 20% awesomeface)
	FragColor = mix(texture(samplerTexture1, TexCoord), texture(samplerTexture2, TexCoord), 0.2);
}
