using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Gluon;

public class AnimationUIBg : MonoBehaviour
{
	[SerializeField]
	private bool expandToCanvasSize;

	[SerializeField]
	public float enterFrame;

	[SerializeField]
	public Vector3 enterOffset;

	[SerializeField]
	public float enterSize;

	[SerializeField]
	public bool enterAlphaChange;

	[SerializeField]
	public float exitFrame;

	[SerializeField]
	public Vector3 exitOffset;

	[SerializeField]
	public float exitSize;

	public Canvas canvas;

	private RectTransform rectTransform;

	private CanvasGroup canvasGroup;

	private Vector2 initialSize;

	private Vector3 initialPosition;

	private Sequence runningSeq;

	public bool skipExitAnimation
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void ResetInitialPosAndSize()
	{
	}

	public void ResetAlpha()
	{
	}

	public void InitAlpha()
	{
	}

	public void StartEnterAnimation()
	{
	}

	public void StartExitAnimation()
	{
	}
}
