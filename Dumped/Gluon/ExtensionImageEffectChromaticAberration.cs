using UnityEngine;

namespace Gluon;

public class ExtensionImageEffectChromaticAberration : ExtensionImageEffect
{
	[SerializeField]
	private Material _material;

	[SerializeField]
	private float _aberrationSize;

	private int _propertyToIDAberrationSize;

	public float aberrationSize
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
