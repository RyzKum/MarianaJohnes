Shader "Custom/SpriteScrollingTransparency"
{
    Properties
    {
        _MainTex ("Sprite Texture", 2D) = "white" {}
        _ScrollSpeedX ("Scroll Speed X", Range(-1, 1)) = 0
        _ScrollSpeedY ("Scroll Speed Y", Range(-1, 1)) = 0
        _Color ("Tint", Color) = (1, 1, 1, 1)
        _Alpha ("Alpha", Range(0, 1)) = 1
    }

    SubShader
    {
        Tags {"Queue"="Transparent" "RenderType"="Transparent"}

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float _ScrollSpeedX;
            float _ScrollSpeedY;
            fixed4 _Color;
            float _Alpha;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float2 uv = i.uv;
                uv += float2(_ScrollSpeedX, _ScrollSpeedY) * _Time.y;
                fixed4 col = tex2D(_MainTex, uv);
                col.a *= _Color.a * _Alpha;
                col.rgb *= col.a;
                return col;
            }
            ENDCG
        }
    }
}