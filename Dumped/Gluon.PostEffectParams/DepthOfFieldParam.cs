using System;
using UnityEngine;

namespace Gluon.PostEffectParams;

[Serializable]
public class DepthOfFieldParam
{
	public float resolutionScale;

	public DofFocalType focalType;

	public float focalSize;

	public float focalLength;

	public float minFocalLength;

	public float maxFocalLength;

	public Transform focalTransfrom;

	public Vector3 focalPosition;

	public float smoothness;

	public float smoothStepMin;

	public float smoothStepMax;
}
