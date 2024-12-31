// Upgrade NOTE: upgraded instancing buffer 'Props' to new syntax.

Shader "Custom/WaterShader" {
	Properties {
		_Color ("Color", Color) = (1,1,1,1)
		_BumpMap  ("Bumpmap", 2D) = "bump" {}
		_Glossiness ("Smoothness", Range(0,1)) = 0.5
		_Metallic ("Metallic", Range(0,1)) = 0.0
		_Speed ("Speed", Range(0,1)) = 0.0
	}
	SubShader {
		Tags { "RenderType"="Transparent" "Queue"="Transparent" }
		LOD 200
		
		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Standard fullforwardshadows alpha:fade

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0

		sampler2D _BumpMap;

		struct Input {
			float2 uv_BumpMap;
		};

		half _Glossiness;
		half _Metallic;
		half _Speed;
		fixed4 _Color;

		void surf (Input IN, inout SurfaceOutputStandard o) {
			// Albedo comes from a texture tinted by color
			fixed4 c = _Color;
			o.Albedo = c.rgb;
			// Metallic and smoothness come from slider variables
			o.Metallic = _Metallic;
			o.Smoothness = _Glossiness;
			fixed3 n1 = UnpackNormal (tex2D (_BumpMap, IN.uv_BumpMap+half2(1,1)*_Time*_Speed));
			fixed3 n2 = UnpackNormal (tex2D (_BumpMap, IN.uv_BumpMap-half2(1,1)*_Time*_Speed*0.5));
			o.Normal = (n1+n2).rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
