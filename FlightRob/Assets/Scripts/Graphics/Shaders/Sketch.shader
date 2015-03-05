Shader "Custom/Sketch" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}

      _BumpMap ("Bumpmap", 2D) = "bump" {}
      _Detail ("Detail", 2D) = "gray" {}
      _Ramp ("Ramp", 2D) = "gray" {}
	}
// 	SubShader {
// 		Tags { "RenderType"="Opaque" }
// 		LOD 200
// 		
// 		CGPROGRAM
// 		#pragma surface surf Lambert
// 
// 		sampler2D _MainTex;
// 
// 		struct Input {
// 			float2 uv_MainTex;
// 		};
// 
// 		void surf (Input IN, inout SurfaceOutput o) {
// 			half4 c = tex2D (_MainTex, IN.uv_MainTex);
// 			o.Albedo = c.rgb;
// 			o.Alpha = c.a;
// 		}
// 		ENDCG
// 	} 
    SubShader {
      Tags { "RenderType" = "Opaque" }
      CGPROGRAM

		#pragma surface surf Ramp

		sampler2D _Ramp;

		half4 LightingRamp (SurfaceOutput s, half3 lightDir, half atten) {
			half NdotL = dot (s.Normal, lightDir);
			half diff = NdotL * 0.9 + 0.1;
			half3 ramp = tex2D (_Ramp, float2(diff,diff)).rgb;
			half4 c;
			c.rgb = s.Albedo * _LightColor0.rgb * ramp * (atten * 2);
			c.a = s.Alpha;
			return c;
		}
    

      struct Input {
          float2 uv_MainTex;
          float2 uv_BumpMap;
          float2 uv_Detail;
      };
      sampler2D _MainTex;
      sampler2D _BumpMap;
      sampler2D _Detail;
      void surf (Input IN, inout SurfaceOutput o) {
          o.Albedo = tex2D (_MainTex, IN.uv_MainTex).rgb;
          o.Albedo *= tex2D (_Detail, IN.uv_Detail).rgb * 2;
          o.Normal = UnpackNormal (tex2D (_BumpMap, IN.uv_BumpMap));
      }
      ENDCG
    } 
	FallBack "Diffuse"
}
