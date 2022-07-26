using Cute.Core;
using UnityEngine;

namespace Gluon;

public class CircleGauge : FastUpdateMonoBehaviour
{
	[SerializeField]
	private float _circleGaugeValue;

	[SerializeField]
	private float _maxCircleGaugeValue;

	[SerializeField]
	private float _startOffsetAngle;

	private SpriteRenderer _spriteRenderer;

	private void Awake()
	{
	}

	public void SetCircleValue(float v)
	{
	}
}
