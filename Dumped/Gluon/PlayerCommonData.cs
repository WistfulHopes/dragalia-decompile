using System;
using UnityEngine;

namespace Gluon;

[Serializable]
public class PlayerCommonData
{
	[SerializeField]
	private AnimationCurve _slipMoveCurve;

	[SerializeField]
	private AnimationCurve _slipTurnCurve;

	[SerializeField]
	private float _slipTurnTime;

	public AnimationCurve SlipMoveCurve => null;

	public AnimationCurve SlipTurnCurve => null;

	public float SlipTurnTime => default(float);
}
