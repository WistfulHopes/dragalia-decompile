using System;
using UnityEngine;

namespace Gluon.PostEffectParams;

[Serializable]
public class PostFilmParam
{
	public PostFilmMode filmMode;

	public float filmPower;

	public Vector2 filmOffsetParam;

	public float vignetteIntensity;

	public float vignetteDecrement;

	public Color filmColor0;

	public Color filmColor1;

	public Color filmColor2;

	public Color filmColor3;

	public void SetColorAll(Color color)
	{
	}
}
