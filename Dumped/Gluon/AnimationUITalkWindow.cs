using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon;

public class AnimationUITalkWindow : AnimationUIBase
{
	[SerializeField]
	private float exitRotationDuration;

	[SerializeField]
	private float exitOverRunZ;

	[SerializeField]
	private float exitOverRunDuration;

	[SerializeField]
	private bool shouldUseCustomDelay;

	[SerializeField]
	private bool plainScaleEnterAnimation;

	[HideInInspector]
	public bool ignoreDelay;

	public override void Awake()
	{
	}

	public override void StartEnterAnimation([Optional] Action onAnimationDone)
	{
	}

	public override void StartExitAnimation([Optional] Action onAnimationDone)
	{
	}

	public void StartCloseOpenAnimation(Action changeTextAction, [Optional] Action onAnimationDone)
	{
	}

	public override void ResetUIAnimations()
	{
	}

	public void ResetEnterAnimationPlayStatus()
	{
	}

	public void ResetExitAnimationPlayStatus()
	{
	}
}
