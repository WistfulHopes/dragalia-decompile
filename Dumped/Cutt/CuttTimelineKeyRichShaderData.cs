using System;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Cutt;

[Serializable]
public class CuttTimelineKeyRichShaderData : CuttTimelineKeyWithInterpolate
{
	public Color toonGlobalShadowColor;

	public Color toonGlobalShadowGlowColor;

	public HSVParameterBase toonCommonEdgeShadowHSV;

	public Vector3 toonLightParamRoatate;

	public float outlineWidthClampMin;

	public float outlineWidthClampMax;

	public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

	public override void OnLoad(CuttTimelineControl timelineControl)
	{
	}

	public CuttTimelineKey Interpolate(CuttTimelineKey interpKey, CuttTimelineKey prevKey, float t)
	{
		return null;
	}
}
