using DG.Tweening;
using UnityEngine;

namespace Gluon;

public class CharaGimmickCustomPointGaugeUI4 : CharaGimmickBaseGaugeUI
{
	[SerializeField]
	protected RectTransform _rootRt;

	[SerializeField]
	protected RectTransform _gaugeBgAnimRt;

	[SerializeField]
	protected RectTransform _iconAnimRt;

	[SerializeField]
	protected InGameGaugeUISpriteRenderer _gauge;

	[SerializeField]
	protected SpriteRenderer _gaugeBgImage;

	[SerializeField]
	protected SpriteRenderer _iconImage;

	[SerializeField]
	protected SpriteRenderer _gaugeBgAnimImage;

	[SerializeField]
	protected SpriteRenderer _iconAnimImage;

	[SerializeField]
	protected Vector2 _countAnimScale;

	[SerializeField]
	protected float _countAnimTime;

	[SerializeField]
	protected Vector2 _gaugeAnimScale;

	[SerializeField]
	protected float _gaugeAnimTime;

	[SerializeField]
	protected float _gaugeInsideWaitTime;

	[SerializeField]
	protected Color _defaultColor;

	[SerializeField]
	protected Color _enhancedColor;

	protected VisibleUIObject _visible;

	protected Sequence _seqIconAnim;

	protected Sequence _seqGaugeAnim;

	protected float _requestRate;

	protected float _requestDelay;

	protected bool _requestImmediate;

	protected int _lastAppearanceType;

	public static CharaGimmickCustomPointGaugeUI4 Create(CharacterBase chara, GameObject parent, int siblingIndex = -1)
	{
		return null;
	}

	protected virtual void Initialize(CharacterBase chara)
	{
	}

	private void OnDestroy()
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

	private void UpdateGaugeValue()
	{
	}

	private float GetSequenceRemainTime(ref Sequence seq)
	{
		return default(float);
	}

	protected void PlayIconAnim()
	{
	}

	protected void PlayGaugeBgAnim()
	{
	}

	protected void OnUpdateAnim(RectTransform trans, Vector2 fromScale, Vector2 toScale, SpriteRenderer sprite, float fromFade, float toFade, float t)
	{
	}

	private void SetIconImage(Material mat)
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

	public override void ChangeAppearance(int type, bool isForce = false)
	{
	}
}
