using System;
using System.Collections;
using UnityEngine;

namespace Gluon;

public class AnimationUIAutoPublisher : MonoBehaviour
{
	[SerializeField]
	public AnimationUIAutoSet[] uiSets;

	public const float animationFPS = 60f;

	[SerializeField]
	public int enterDuration;

	[SerializeField]
	public Vector3 enterRotation;

	[SerializeField]
	public int enterRotationDelay;

	[SerializeField]
	public Vector3 enterOffset;

	[SerializeField]
	public Vector3 enterBoundOffset;

	[SerializeField]
	public float enterBoundScale;

	[SerializeField]
	public int exitDuration;

	[SerializeField]
	public float exitScale;

	[SerializeField]
	public float exitSpeed;

	[SerializeField]
	public float exitDirection;

	[SerializeField]
	public Vector3 exitOffset;

	[SerializeField]
	public Vector3 exitRotation;

	[SerializeField]
	public bool bAutoStartEnterAnimation;

	[SerializeField]
	public bool bAutoClearAnimation;

	[SerializeField]
	public AnimationUICanvas.AnimationPattern pattern;

	[SerializeField]
	public AnimationUIBase.AnimationEnableType enableType;

	private void Awake()
	{
	}

	public void PreheatAll()
	{
	}

	public void RePublishAll()
	{
	}

	private void Start()
	{
	}

	public void PlayEnterAnimation(Action onFinished, int setIndex = -1)
	{
	}

	private IEnumerator EnterAnimationCoroutine(Action onFinished, int setIndex = -1)
	{
		return null;
	}

	public void PlayExitAnimation(Action onFinished, int setIndex = -1)
	{
	}

	private void CheckAndClearPlayState(int setIndex = -1)
	{
	}

	public void ForceClearPlayedStatus(int setIndex = -1)
	{
	}

	public void CompleteRunningAnimation(int setIndex = -1)
	{
	}

	private IEnumerator ExitAnimationCoroutine(Action onFinished, int setIndex = -1)
	{
		return null;
	}
}
