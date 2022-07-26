using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon;

public class UIAnimationPublisher : MonoBehaviour
{
	public enum DelayOrderType
	{
		Auto,
		Ascending,
		Descending
	}

	[SerializeField]
	public UIAnimationSetting[] settings;

	[SerializeField]
	public bool bAutoStartEnterAnimation;

	[SerializeField]
	public bool bAutoClearAnimation;

	[SerializeField]
	public AnimationUICanvas.AnimationPattern pattern;

	[SerializeField]
	public UIAnimationBase.AnimationEnableType enableType;

	[SerializeField]
	public GameObject[] objsInSetting;

	public UIAnimationSetting templateSetting;

	public bool firstInFirstOut;

	public DelayOrderType enterDelayType;

	public DelayOrderType exitDelayType;

	[SerializeField]
	public bool overrideOriginal;

	[SerializeField]
	public bool doNotPublishToInactive;

	[SerializeField]
	public bool waitEvenIfNoObjectsPublished;

	public bool shouldReEnableChildrenAfterExit;

	private List<UIAnimationBase> uiAnimationBaseList;

	public const int defaultMaximumCutoffDurationInFrame = 11;

	public const float defaultMaximumCutoffDuration = 11f / 30f;

	public const int defaultHalfCutoffDurationInFrame = 6;

	public const float defaultHalfCutoffDuration = 0.2f;

	public float maximumCutoffDuration;

	public float halfCutoffDuration;

	[NonSerialized]
	public bool ignoreTimeScale;

	public bool onEnterAnimation
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool onExitAnimation
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public UnityEvent onEnterEvent
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

	public UnityEvent onExitEvent
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

	private void Awake()
	{
	}

	public void PreheatAll()
	{
	}

	public void ResetUIAnimations()
	{
	}

	public static UIAnimationPublisher[] GetValidPublisherList(UIAnimationPublisher[] publishers, AnimationUICanvas.AnimationPattern pattern, UIAnimationBase.AnimationEnableType enableType)
	{
		return null;
	}

	public void RePublishSetting()
	{
	}

	public void RePublishAll()
	{
	}

	public bool IsSamePattern(AnimationUICanvas.AnimationPattern pattern)
	{
		return default(bool);
	}

	public bool IsEnableTypeMatch(UIAnimationBase.AnimationEnableType enableType)
	{
		return default(bool);
	}

	public bool IsOnAnimation()
	{
		return default(bool);
	}

	private void Start()
	{
	}

	public void PlayEnterAnimation(Action onFinished, [Optional] Action onHalfFinished)
	{
	}

	private IEnumerator EnterAnimationCoroutine(Action onFinished, Action onHalfFinished)
	{
		return null;
	}

	public void PlayExitAnimation(Action onFinished, [Optional] Action onHalfFinished)
	{
	}

	private IEnumerator ExitAnimationCoroutine(Action onFinished, [Optional] Action onHalfFinished)
	{
		return null;
	}

	private void CheckAndClearPlayState()
	{
	}

	public void ForceClearPlayedStatus()
	{
	}

	public void CompleteRunningAnimation()
	{
	}

	private void ReleaseUIAnimationForObject(GameObject obj)
	{
	}

	public int RemoveObject(GameObject obj)
	{
		return default(int);
	}

	public void OverrideObjectAtIndex(int index, GameObject obj)
	{
	}
}
