using System;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon;

[CreateAssetMenu]
public class SceneRichShaderData : ScriptableObject, IShaderData<SceneRichShaderData>
{
	[Serializable]
	public class ShadowParam : IShaderData<ShadowParam>
	{
		public float step;

		public float feather;

		public void Copy(ShadowParam src)
		{
		}
	}

	[Serializable]
	public class ToonShadingData : IShaderData<ToonShadingData>
	{
		public Color toonGlobalShadowColor;

		public Color toonGlobalShadowGlowColor;

		public HSVParameterBase toonCommonEdgeShadowHSV;

		public Vector3 toonLightParamRoatate;

		public Texture2D matcapProjectionTex;

		public float matcapProjectionTexLevel;

		public Color matcapProjectionColor;

		public float matcapProjectionIntensity;

		public ShadowParam shadowToon;

		public ShadowParam shadowEdge;

		public ShadowParam shadowGlow;

		public void Copy(ToonShadingData src)
		{
		}
	}

	[Serializable]
	public class OutlineData : IShaderData<OutlineData>
	{
		public Color color;

		public float width;

		public float widthClampMin;

		public float widthClampMax;

		public float offset;

		public bool useColor2;

		public Color color2;

		public void Copy(OutlineData src)
		{
		}
	}

	public ToonShadingData toonShadingData;

	public OutlineData outlineData;

	private ToonShadingData startToonShadingData;

	private OutlineData startOutlineData;

	public void Copy(SceneRichShaderData src)
	{
	}

	public void Reset()
	{
	}

	private void Awake()
	{
	}
}
