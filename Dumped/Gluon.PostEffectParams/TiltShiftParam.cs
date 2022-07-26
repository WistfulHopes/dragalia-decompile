using System;

namespace Gluon.PostEffectParams;

[Serializable]
public class TiltShiftParam
{
	[Serializable]
	public struct PointIrisSetting
	{
		public float pointIrisCenterX;

		public float pointIrisCenterY;

		public float pointIrisRadiusX;

		public float pointIrisRadiusY;
	}

	public bool isDebugMode;

	public float resolutionScale;

	public float blurArea;

	public float blurPower;

	public float blurOffset;

	public float blurBaseUp;

	public PointIrisSetting[] pointIrisSettings;

	public float pointIrisCutout;

	public void setPointIrisSetting(int index, float centerX, float centerY, float radiusX, float radiusY)
	{
	}
}
