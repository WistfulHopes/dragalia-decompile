using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon;

public class ExtensionImageEffectChangeHSV : ExtensionImageEffect
{
	[SerializeField]
	private Material _material;

	[SerializeField]
	private HSVParameterBase _HSVParameter;

	private int _propertyToIDHSVMatrix;

	public HSVParameterBase HSVParameter => null;

	private void Awake()
	{
	}

	public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture)
	{
		return default(bool);
	}
}
