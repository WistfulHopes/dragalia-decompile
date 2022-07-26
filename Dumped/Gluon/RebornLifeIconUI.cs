using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon;

public class RebornLifeIconUI : FastUpdateMonoBehaviour
{
	[SerializeField]
	private RectTransform _rootRt;

	[SerializeField]
	private RectTransform _onRt;

	[SerializeField]
	private RectTransform _heartRt;

	[SerializeField]
	private RectTransform _ringRt;

	[SerializeField]
	private RectTransform _gradationRt;

	[SerializeField]
	private RectTransform _heart2Rt;

	[SerializeField]
	private SpriteRenderer _offImage;

	[SerializeField]
	private SpriteRenderer _onImage;

	[SerializeField]
	private SpriteRenderer _heartImage;

	[SerializeField]
	private SpriteRenderer _ringImage;

	[SerializeField]
	private SpriteRenderer _gradationImage;

	[SerializeField]
	private SpriteRenderer _heart2Image;

	private VisibleUIObject _rootVisible;

	private Sequence _animSeq;

	private int _index;

	public bool isEnable
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

	public bool isVisible => default(bool);

	public static RebornLifeIconUI Create(GameObject pobj, GameObject parent, int index, bool enable, int siblingIndex = -1)
	{
		return null;
	}

	private void Initialize(int index, bool enable)
	{
	}

	private void OnDestroy()
	{
	}

	public void SetEnable(bool enable, bool force = false)
	{
	}

	public void SetVisible(bool visible)
	{
	}

	public void PlayShowAnim(float waitTime, [Optional] Action onComplete)
	{
	}

	public void PlayBlinkAnim()
	{
	}

	public void PlayConsumeAnim([Optional] Action onComplete)
	{
	}

	public void SetFade(float fade)
	{
	}
}
