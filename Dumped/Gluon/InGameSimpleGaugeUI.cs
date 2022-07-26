using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon;

public class InGameSimpleGaugeUI : FastUpdateMonoBehaviour
{
	private enum BaseGaugeState
	{
		Normal,
		Max
	}

	[SerializeField]
	private RectTransform _rootRt;

	[SerializeField]
	private SpriteRenderer _baseGaugeImage;

	[SerializeField]
	private bool _useGaugeSprite;

	[SerializeField]
	private Sprite[] _gaugeSprite;

	[SerializeField]
	private Color _baseGaugeColor;

	[SerializeField]
	private Color _maxGaugeColor;

	[SerializeField]
	private float _initialValue;

	[SerializeField]
	private float _waitTime;

	[SerializeField]
	private float _diffMoveTime;

	[SerializeField]
	private bool _isNineSlice;

	[SerializeField]
	private bool _isMoveHorizontal;

	private VisibleUIObject _visible;

	private RectTransform _baseGaugeImageRt;

	private Vector2 _baseGaugeOriginalSize;

	private float _targetGaugeRate;

	private float _lastBaseGaugeRate;

	private float _waitRemainTime;

	private bool _lossMoving;

	private bool _gainMoving;

	private bool _isAlphaGauge;

	public Action<float> OnCompleteAnim
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void Initialize()
	{
	}

	public override void FastUpdate()
	{
	}

	private bool UpdateWaitTime(float t)
	{
		return default(bool);
	}

	private void SetBaseGaugeRate(float rate, bool isForce = false)
	{
	}

	private float GetBaseGaugeRate()
	{
		return default(float);
	}

	private void SetBaseGaugeSprite(BaseGaugeState type)
	{
	}

	private void SetBaseGaugeColor(BaseGaugeState type)
	{
	}

	public void SetGaugeRate(float rate, bool immediate, float waitTime = 0f)
	{
	}

	public float GetGaugeRate()
	{
		return default(float);
	}

	public bool IsGaugeMax()
	{
		return default(bool);
	}

	public bool IsGaugeEmpty()
	{
		return default(bool);
	}

	public void Visible(bool value)
	{
	}

	public void SetWaitTime(float time)
	{
	}

	public void SetBaseGaugeColor(Color color)
	{
	}

	public void SetMaxGaugeColor(Color color)
	{
	}

	public float GetGaugeMoveTime()
	{
		return default(float);
	}

	private bool CopyMaterialForAlphaGauge(ref SpriteRenderer image, out bool isAlphaGauge)
	{
		return default(bool);
	}
}
