using System;
using UnityEngine;

namespace Gluon;

public class PostEffectSunShafts : ExtensionImageEffect
{
	[Serializable]
	public class SunShaftsParam
	{
		public enum SunShaftsShadeMode
		{
			Default,
			Komorebi
		}

		public enum SunShaftsScreenBlendMode
		{
			Screen,
			Add
		}

		public bool IsEnable;

		public Transform SunTransform;

		public Vector3 SunPosition;

		public float sunShaftResolutionRate;

		public SunShaftsShadeMode sunShaftsShadeMode;

		public SunShaftsScreenBlendMode ScreenBlendMode;

		public float SunShaftBlurRadius;

		public Color SunColor;

		public float SunPower;

		public float CenterBrightness;

		public float CenterMultiplex;

		public bool IsEnabledBorderClear;

		public float SunShaftIntensity;

		public float BlackLevel;

		public int BlurIterations;

		[NonSerialized]
		public RenderTexture CameraDepthTexture;

		public void Setup(SunShaftsParam src)
		{
		}
	}

	[SerializeField]
	protected Material _sunShaftsMaterial;

	[SerializeField]
	protected Material _simpleClearMaterial;

	[SerializeField]
	private SunShaftsParam _param;

	public SunShaftsParam Param => null;

	public bool IsEnable => default(bool);

	public bool IsUseDepthTexture => default(bool);

	public bool CreateMaterial()
	{
		return default(bool);
	}

	public void ResetDepthTexture()
	{
	}

	private void DrawBorder(RenderTexture dest, Material material)
	{
	}

	private void Start()
	{
	}

	public override DepthTextureMode GetNeedDepthTextureMode()
	{
		return default(DepthTextureMode);
	}

	public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture)
	{
		return default(bool);
	}

	public void DestroyMaterial()
	{
	}
}
