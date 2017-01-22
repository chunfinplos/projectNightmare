Shader "Unlit/Twofaces"
{
	Properties{
		_MainTex("Base (RGB)", 2D) = ""
	}

	SubShader
	{
		Pass {
			Material {
                Diffuse (1,1,1,1)
            }
            Lighting On
            Cull Off
			SetTexture [_MainTex] {
			}
		}
	}
}
