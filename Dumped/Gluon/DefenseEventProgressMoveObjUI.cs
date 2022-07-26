using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon;

public class DefenseEventProgressMoveObjUI : FastUpdateMonoBehaviour
{
	protected enum State
	{
		None,
		Appear,
		Attack,
		Disappear
	}

	[SerializeField]
	protected RectTransform _rootRt;

	[SerializeField]
	protected RectTransform _iconRt;

	[SerializeField]
	protected SpriteRenderer _iconImage;

	[SerializeField]
	protected float _moveCompletionThreshold;

	[SerializeField]
	protected float _moveCompletionTime;

	protected State _state;

	protected DefenseEventProgressInfoUI _infoUI;

	protected VisibleUIObject _visible;

	protected EnemyCharacter _enemy;

	protected int _enemySerialId;

	protected int _animIndex;

	protected float _animTime;

	protected Tweener _tweenMove;

	protected Action<int> _OnDisappear;

	protected float _positionRate;

	protected float _lastPositionRate;

	public float sortingPosZ
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public virtual void Initialize(DefenseEventProgressInfoUI infoUI, Material material, Action<int> onDisappear)
	{
	}

	public virtual void Setup(EnemyCharacter chara, DefenseEventInfoCtrl.MoveObjIconType type)
	{
	}

	private void OnDestroy()
	{
	}

	protected virtual void Release()
	{
	}

	public virtual void Show()
	{
	}

	public virtual void Hide()
	{
	}

	public override void FastUpdate()
	{
	}

	public virtual void SetIcon(Sprite sprite)
	{
	}

	public virtual void SetIcon(DefenseEventInfoCtrl.MoveObjIconType type)
	{
	}

	public virtual void SetPosition(float rate)
	{
	}

	public virtual void ApplyPosition()
	{
	}

	public virtual bool IsEndPoint()
	{
		return default(bool);
	}

	public virtual bool IsPlayingAction()
	{
		return default(bool);
	}

	public virtual void PlayAppearAnim()
	{
	}

	protected virtual void UpdateAppearAnim()
	{
	}

	public virtual void PlayAttackAnim()
	{
	}

	protected virtual void UpdateAttackAnim()
	{
	}

	public virtual void PlayDisappearAnim()
	{
	}

	protected virtual void UpdateDisappearAnim()
	{
	}
}
