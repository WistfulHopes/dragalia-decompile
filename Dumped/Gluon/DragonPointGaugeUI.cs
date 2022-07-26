using System;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon;

public class DragonPointGaugeUI : FastUpdateMonoBehaviour
{
	[Serializable]
	protected class GaugeParam
	{
		[SerializeField]
		protected Sprite[] _gaugeSprites;

		[SerializeField]
		protected Color _gaugeColor;

		public Sprite[] gaugeSprites => null;

		public Color gaugeColor => default(Color);
	}

	public enum DispType
	{
		Valid_01,
		Valid_02,
		Invalid
	}

	[SerializeField]
	private InGameButtonGaugeUI _buttonGauge1;

	[SerializeField]
	private InGameButtonGaugeUI _buttonGauge2;

	[SerializeField]
	protected SpriteRenderer _gaugeEffect;

	[SerializeField]
	protected SpriteRenderer _gaugeLineEffect;

	[SerializeField]
	protected GaugeParam[] _gaugeParams;

	protected DispType _dispType;

	protected RectTransform _gaugeEffectRt;

	protected Tweener _twGaugeEffect;

	protected Tweener _twGaugeLineEffect;

	protected int _targetGaugeLineEffect;

	protected float _rate;

	protected float _gaugeValue1;

	protected float _gaugeValue2;

	public void Initialize(DispType type)
	{
	}

	public void OnDestroy()
	{
	}

	public void UpdateUI()
	{
	}

	public void SetDispType(DispType type, bool isForce = false)
	{
	}

	public bool SetGaugeRate(float rate, bool isForce = false, bool isImmediate = false, bool isWithEffectAndSE = true)
	{
		return default(bool);
	}

	public float GetGaugeRate1()
	{
		return default(float);
	}

	public float GetGaugeRate2()
	{
		return default(float);
	}

	public void StartGaugeEffect()
	{
	}

	protected void OnUpdateEffect(float value)
	{
	}
}
