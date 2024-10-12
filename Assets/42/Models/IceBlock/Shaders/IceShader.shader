Shader "Custom/Ice"
{
    Properties
    {
        _DistortionTex("DistortionTexture", 2D) = "white" {}
        _DistortionLevel("Distort Strength", Float) = 0.0
        _Color("Color", Color) = (1, 1, 1, 1)
    }
    
    SubShader 
    {
        Tags {"Queue"="Transparent" "RenderType"="Transparent" }
        
        Cull Back 
        ZWrite On
        ZTest LEqual
        ColorMask RGB

        GrabPass { "_GrabPassTexture" }

        Pass {

            CGPROGRAM
           #pragma vertex vert
           #pragma fragment frag
            
           #include "UnityCG.cginc"

            struct appdata {
                half4 vertex                : POSITION;
                half4 texcoord              : TEXCOORD0;
				float3 normal 				: NORMAL;
            };
                
            struct v2f {
                half4 vertex                : SV_POSITION;
                half2 uv                    : TEXCOORD0;
                half4 grabPos               : TEXCOORD1;
                half vdotn 				: TEXCOORD2;
            };
            
            sampler2D _DistortionTex;
            fixed4 _DistortionTex_ST;
            sampler2D _GrabPassTexture;
			fixed4 _Color;
			half _DistortionLevel;

            v2f vert (appdata v)
            {
                v2f o                   = (v2f)0;
                
                o.vertex                = UnityObjectToClipPos(v.vertex);
                o.uv                    = TRANSFORM_TEX(v.texcoord, _DistortionTex);
                o.grabPos               = ComputeGrabScreenPos(o.vertex);

				half3 viewDir = normalize(ObjSpaceViewDir(v.vertex));
                o.vdotn = dot(viewDir, v.normal.xyz);
                return o;
            }
            
            fixed4 frag (v2f i) : SV_Target
            {
                half2 uv            = half2(i.grabPos.x / i.grabPos.w, i.grabPos.y / i.grabPos.w);

                // Distortionの値に応じてサンプリングするUVをずらす
                half2 distortion    = tex2D(_DistortionTex, i.uv).rg - 0.5;
				half dl=i.vdotn;
                distortion          *=dl* _DistortionLevel;


                uv                  = uv + distortion;

                return fixed4(tex2D(_GrabPassTexture, uv).xyz*(1-_Color.a)+_Color.xyz*_Color.a,1);
            }
            ENDCG
        }
    }
}