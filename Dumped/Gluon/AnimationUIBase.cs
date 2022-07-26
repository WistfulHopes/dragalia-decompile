using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class AnimationUIBase : MonoBehaviour
{
	public enum AnimationEnableType
	{
		BothEnterAndExit,
		EnterOnly,
		ExitOnly,
		Preheated
	}

	[SerializeField]
	public AnimationUICanvas.AnimationPattern pattern;

	[SerializeField]
	public AnimationEnableType enableType;

	[SerializeField]
	public bool enterAlphaAnimation;

	[SerializeField]
	public int enterDuration;

	[SerializeField]
	public int enterDelay;

	[SerializeField]
	public float enterScale;

	[SerializeField]
	public Vector3 enterRotation;

	[SerializeField]
	public int enterRotationDelay;

	[SerializeField]
	public int enterRotationDuration;

	[SerializeField]
	public Vector3 enterOffset;

	[SerializeField]
	public Ease enterEase;

	[SerializeField]
	public bool isBounds;

	[SerializeField]
	public Vector3 enterBoundOffset;

	[SerializeField]
	public float enterBoundScale;

	[SerializeField]
	public bool exitAlphaAnimation;

	[SerializeField]
	public int exitDuration;

	[SerializeField]
	public int exitDelay;

	[SerializeField]
	public float exitScale;

	[SerializeField]
	public float exitSpeed;

	[SerializeField]
	public float exitDirection;

	[SerializeField]
	public bool useExitOffset;

	[SerializeField]
	public Vector3 exitOffset;

	[SerializeField]
	public Vector3 exitRotation;

	[SerializeField]
	public bool dispOffOnCompletelyExit;

	[SerializeField]
	public Ease exitEase;

	[SerializeField]
	public bool isExitAnimeBounds;

	[SerializeField]
	public Vector3 exitBoundOffset;

	[SerializeField]
	public float exitBoundScale;

	protected RectTransform rectTransform;

	protected Image image;

	protected bool elementsEnabled;

	protected CanvasGroup canvasGroup;

	protected Text[] childTexts;

	protected Image[] childImages;

	protected PointerEventHandler[] childPointEventHandlers;

	protected bool isEnterAnimationPlayed;

	protected bool isExitAnimationPlayed;

	protected const float overRunFrame = 4f;

	protected const float overRunDirection = 10f;

	private List<Behaviour> disabledObjectList;

	protected bool isOnEnterAnimation;

	protected bool isOnExitAnimation;

	protected Vector3 startPosition;

	protected Quaternion startRotation;

	protected Vector3 startScale;

	protected Sequence runningSequence;

	public virtual void Awake()
	{
	}

	public virtual void RecordCurrentStateAsDefault()
	{
	}

	public virtual void ResetUIAnimations()
	{
	}

	public virtual void CompleteRunningAnimations()
	{
	}

	public virtual void KillRunningAnimations()
	{
	}

	public bool IsAnimationRunning()
	{
		return default(bool);
	}

	public virtual void StartEnterAnimation([Optional] Action onAnimationDone)
	{
	}

	public virtual void StartExitAnimation([Optional] Action onAnimationDone)
	{
	}

	protected virtual void AddToDefaultEnterAnimation()
	{
	}

	protected virtual void AddToDefaultExitAnimation()
	{
	}

	public void ForceResetPlayedState(bool enterState, bool exitState)
	{
	}

	protected void DisableChildren()
	{
	}

	protected void EnableChildren(bool includeTouchEvent = true)
	{
	}

	protected void DisableTouchEventChildren()
	{
	}

	protected void EnableTouchEventChildren()
	{
	}

	public bool IsOnAnimation()
	{
		return default(bool);
	}

	public bool IsSamePattern(AnimationUICanvas.AnimationPattern animationPattern)
	{
		return default(bool);
	}
}
