using System;
using UnityEngine;

namespace Gluon;

public class PostEffectGlobalFog : ExtensionImageEffect
{
	[Serializable]
	public class DistanceFogParam
	{
		[SerializeField]
		public FogMode fogMode;

		[SerializeField]
		public Color fogColor;

		[SerializeField]
		public float density;

		[SerializeField]
		public float start;

		[SerializeField]
		public float end;
	}

	[Serializable]
	public class HeightFogParam
	{
		[SerializeField]
		public Color fogColor;

		[SerializeField]
		public FogMode fogMode;

		[SerializeField]
		public float decay;

		[SerializeField]
		public float height;

		[SerializeField]
		public float concentration;

		[SerializeField]
		public bool enableDensitySmooth;

		[SerializeField]
		public float densitySmoothMin;

		[SerializeField]
		public float densitySmoothMax;

		public void Setup(HeightFogParam src)
		{
		}
	}

	[SerializeField]
	private Material _material;

	[SerializeField]
	private bool _enableDistanceFog;

	[SerializeField]
	private bool _enableHeightFog;

	[SerializeField]
	private DistanceFogParam _distanceFogParam;

	[SerializeField]
	private HeightFogParam _heightFogParam;

	public bool enableDistanceFog
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool enableHeightFog
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public DistanceFogParam distanceFogParam => null;

	public HeightFogParam heightFogParam => null;

	public override DepthTextureMode GetNeedDepthTextureMode()
	{
		return default(DepthTextureMode);
	}

	private void Start()
	{
	}

	private void OnPreRender()
	{
	}

	public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture)
	{
		return default(bool);
	}
}
