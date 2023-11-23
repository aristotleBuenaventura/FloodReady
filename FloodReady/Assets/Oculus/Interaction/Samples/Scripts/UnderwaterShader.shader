// UnderwaterShader.shader

Shader"Custom/UnderwaterShader"
{
    Properties
    {
        _MainTex ("Base (RGB)", 2D) = "white" { }
        _UnderwaterColor ("Underwater Color", Color) = (0.0, 0.5, 1.0, 1.0)
    }

    SubShader
    {
        Tags { "RenderType"="Opaque" }
LOD100

        CGPROGRAM
        #pragma surface surf Lambert

struct Input
{
    float2 uv_MainTex;
};

fixed4 _UnderwaterColor;

void surf(Input IN, inout SurfaceOutput o)
{
    fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
    o.Albedo = c.rgb + _UnderwaterColor.rgb;
    o.Alpha = c.a;
}
        ENDCG
    }

FallBack"Diffuse"
}