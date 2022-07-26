using System;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon;

public class InGameAnimUI : FastUpdateMonoBehaviour
{
	[Serializable]
	public class AnimData
	{
		public Vector3 scale;

		public float fade;

		public float animTime;

		public float afterWaitTime;

		public Ease ease;

		[HideInInspector]
		public Vector3 prevScale;

		[HideInInspector]
		public float prevFade;
	}

	[SerializeField]
	protected RectTransform[] _animRt;

	[SerializeField]
	protected SpriteRenderer[] _animImage;

	[SerializeField]
	protected int _loopCount;

	[SerializeField]
	protected float _startWaitTime;

	[SerializeField]
	protected AnimData[] _animData;

	protected Sequence _seqAnim;

	protected Color[] _originColor;

	protected Action _onComplete;

	protected bool _isEnableScaleAnim;

	protected bool _isEnableFadeAnim;

	public void Awake()
	{
	}

	public void Initialize(Action onComplete)
	{
	}

	public void OnDestroy()
	{
	}

	public bool Play(bool isForce = false)
	{
		return default(bool);
	}

	public void Stop()
	{
	}

	public bool IsPlaying()
	{
		return default(bool);
	}

	private Sequence CreateAnim()
	{
		return null;
	}

	private void ApplyImageData(AnimData data)
	{
	}

	private void OnUpdateScale(Vector3 scale)
	{
	}

	private void OnUpdateFade(float fade)
	{
	}
}
