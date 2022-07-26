using System;
using Cute.Core;
using UnityEngine;

namespace Gluon;

public class DefenseEventProgressInfoUI : FastUpdateMonoBehaviour
{
	[SerializeField]
	protected RectTransform _rootRt;

	[SerializeField]
	protected RectTransform _fortRt;

	[SerializeField]
	protected RectTransform[] _glitterRt;

	[SerializeField]
	protected RectTransform _moveObjRt;

	[SerializeField]
	protected RectTransform _lineStartRt;

	[SerializeField]
	protected RectTransform _lineEndRt;

	[SerializeField]
	protected RectTransform _gaugeRt;

	[SerializeField]
	protected SpriteRenderer _fortImage;

	[SerializeField]
	protected SpriteRenderer _fortImageAdd;

	[SerializeField]
	protected SpriteRenderer _lineImage;

	[SerializeField]
	protected SpriteRenderer _gaugeBgImage;

	[SerializeField]
	protected SpriteRenderer[] _glitterImage;

	[SerializeField]
	protected SpriteRenderer[] _glitterImageAdd;

	[SerializeField]
	protected InGameGaugeUISpriteRenderer _gaugeUI;

	[SerializeField]
	protected DefenseEventLineMsgUI _lineMsg;

	[SerializeField]
	protected DefenseEventProgressMoveObjUI _originMoveObj;

	[SerializeField]
	protected Sprite _sprFort;

	[SerializeField]
	protected Sprite _sprFortAdd;

	[SerializeField]
	protected Sprite _sprLine;

	[SerializeField]
	protected Sprite _sprGaugeBg;

	[SerializeField]
	protected Sprite _sprGlitter;

	[SerializeField]
	protected Sprite[] _spriteIconList;

	[SerializeField]
	protected Sprite _sprMsg;

	[SerializeField]
	protected Material _matSprite;

	[SerializeField]
	protected Material _matAddSprite;

	[SerializeField]
	protected Material _matDOTween;

	[SerializeField]
	protected Vector2 _glitterScale;

	[SerializeField]
	protected Vector2 _glitterStartDelayTime;

	[SerializeField]
	protected Vector2 _glitterCorrectRadius;

	[SerializeField]
	protected float _fortDamageMsgIntervalTime;

	[SerializeField]
	protected float _fortDyingMsgHpRate;

	protected int animIndex;

	protected int[] glitterAnimIndexs;

	protected float animTime;

	protected float[] glitterAnimTimes;

	protected float[] glitterAnimDelayTimes;

	protected bool isPlaying;

	protected InGameFollowLayout _followLayout;

	protected TweenUtil.ColorModulusArgs _colorModulusFort;

	protected float _fortDamageMsgIntervalCount;

	protected bool _isFortDyingMsgDisplayed;

	private const float GlitterDefaultScale = 100f;

	public RectTransform moveObjRt => null;

	public static DefenseEventProgressInfoUI Create(GameObject parent, InGameUIConst.DecorationType type, int siblingIndex = -1)
	{
		return null;
	}

	public virtual void Initialize(InGameUIConst.DecorationType type)
	{
	}

	private void OnDestroy()
	{
	}

	protected virtual void Release()
	{
	}

	public override void FastUpdate()
	{
	}

	public virtual void Show()
	{
	}

	public virtual void Hide()
	{
	}

	protected virtual void Visible(bool b, bool force = false)
	{
	}

	public virtual void SetFortHpRate(float rate, bool immediate)
	{
	}

	public virtual Sprite GetIconSprite(DefenseEventInfoCtrl.MoveObjIconType type)
	{
		return null;
	}

	public virtual DefenseEventProgressMoveObjUI CreateMoveObj(Action<int> onDisappear)
	{
		return null;
	}

	public virtual DefenseEventLineMsgUI GetLineMsg(GameObject parent)
	{
		return null;
	}

	public virtual Vector3 GetMoveObjPosition(float rate)
	{
		return default(Vector3);
	}

	public virtual void ActionFortDamage()
	{
	}

	protected virtual void InitFortDamage()
	{
	}

	protected virtual void UpdateFortDamage(float deltaTime)
	{
	}
}
