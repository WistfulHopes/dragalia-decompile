using System;

namespace Cutt;

[Serializable]
public class CuttTimelineKeyGraphicSpeedData : CuttTimelineKeyWithInterpolate
{
	public float graphicTimeScale;

	public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

	public override void OnLoad(CuttTimelineControl timelineControl)
	{
	}

	public CuttTimelineKey Interpolate(CuttTimelineKey interpKey, CuttTimelineKey prevKey, float t)
	{
		return null;
	}
}
