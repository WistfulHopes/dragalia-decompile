using System;
using DG.Tweening;
using UnityEngine;

namespace Gluon;

public class CharaGimmickCustomPointGaugeUI2 : CharaGimmickBaseGaugeUI
{
	[SerializeField]
	protected RectTransform _rootRt;

	[SerializeField]
	protected RectTransform _gaugeBgAnimRt;

	[SerializeField]
	protected RectTransform _gaugeBgAnimAdjustRt;

	[SerializeField]
	protected RectTransform _iconAnimRt;

	[SerializeField]
	protected RectTransform[] _stepGaugeRt;

	[SerializeField]
	protected InGameGaugeUISpriteRenderer _gauge;

	[SerializeField]
	protected SpriteRenderer _gaugeBgAnimImage;

	[SerializeField]
	protected SpriteRenderer _iconImage;

	[SerializeField]
	protected SpriteRenderer _iconAnimImage;

	[SerializeField]
	protected Vector2 _countAnimScale;

	[SerializeField]
	protected float _countAnimTime;

	[SerializeField]
	protected Vector2 _gaugeAnimScale;

	[SerializeField]
	protected Vector2 _gaugeAnimScale2;

	[SerializeField]
	protected float[] _gaugeAnimStepScaleX;

	[SerializeField]
	protected float _gaugeAnimTime;

	[SerializeField]
	protected float _gaugeIntervalTime;

	[SerializeField]
	protected float _gaugeAnimTime2;

	[SerializeField]
	protected float _gaugeInsideWaitTime;

	[SerializeField]
	protected float _gaugeHidePostTime;

	[SerializeField]
	protected Color[] _gaugeColor;

	protected VisibleUIObject _visible;

	protected Sequence _seqIconAnim;

	protected Sequence _seqGaugeAnim;

	protected float _lastRate;

	protected int _requestCP;

	protected int _requestMaxCP;

	protected float _requestRate;

	protected float _requestDelay;

	protected bool _requestImmediate;

	protected bool _requestPlayAnim;

	protected bool _maxPlayAnim;

	protected float _maximumValuePerGauge;

	protected bool[] _animPlayed;

	protected Action<int, int, int> _onStepoverCallback;

	protected int _stepoverCallbackArgeIndex;

	protected int _lastGaugeIndex;

	public static CharaGimmickCustomPointGaugeUI2 Create(CharacterBase chara, GameObject parent, int siblingIndex = -1)
	{
		return null;
	}

	protected virtual void Initialize(CharacterBase chara)
	{
	}

	protected void OnDestroy()
	{
	}

	public override void FastUpdate()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public override bool IsVisible()
	{
		return default(bool);
	}

	public override void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false, bool isForce = false)
	{
	}

	protected virtual void UpdateGaugeValue()
	{
	}

	protected void UpdateGaugeAnimParam()
	{
	}

	protected void UpdateGaugeStatus(float gaugeRate, float targetGaugeRate)
	{
	}

	protected float GetSequenceRemainTime(ref Sequence seq)
	{
		return default(float);
	}

	public override void SetGaugeAnimCompleteCallback(int idx, Action<int, int, int> onComplete)
	{
	}

	protected void PlayIconAnim()
	{
	}

	protected void PlayGaugeBgAnim()
	{
	}

	protected void OnUpdateAnim(RectTransform trans, Vector3 fromScale, Vector3 toScale, SpriteRenderer sprite, float fromFade, float toFade, float t)
	{
	}

	protected void SetIconImage(Material mat)
	{
	}

	public override int GetGaugeType()
	{
		return default(int);
	}

	public override float GetGaugeMoveTime()
	{
		return default(float);
	}
}
