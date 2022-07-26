using System;

namespace Gluon.PostEffectParams;

[Serializable]
public class BloomParam
{
	public float resolutionScale;

	public float bloomWeight;

	public float bloomThreshold;

	public float bloomIntensity;

	public float bloomLuminancePower;
}
