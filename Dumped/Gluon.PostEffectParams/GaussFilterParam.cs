using System;

namespace Gluon.PostEffectParams;

[Serializable]
public class GaussFilterParam
{
	public GaussType gaussHorizon;

	public GaussType gaussVertical;

	public float blurSize;

	public float blurPower;
}
