using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon;

public class ExtensionImageEffectCronos : ExtensionImageEffect
{
	[SerializeField]
	private Material _material;

	[SerializeField]
	private float _fadeValue;

	private int _propertyToIDFadeValue;

	[SerializeField]
	private HSVParameterBase _HSVParameter;

	public float fadeValue
	{
		set
		{
		}
	}

	private void Awake()
	{
	}

	public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture)
	{
		return default(bool);
	}
}
