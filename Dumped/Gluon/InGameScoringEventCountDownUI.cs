using System;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon;

public class InGameScoringEventCountDownUI : FastUpdateMonoBehaviour
{
	[Serializable]
	private class TimeData
	{
		public float time;

		public Vector3 leftTextPos;

		public Vector3 rightTextPos;

		public Vector3 leftTextScale;

		public Vector3 rightTextScale;

		public Sprite numberImage_10;

		public Sprite numberImage_01;

		public Vector3 numberPos_10;

		public Vector3 numberPos_01;

		public Vector3 numberScale_10;

		public Vector3 numberScale_01;
	}

	[SerializeField]
	private RectTransform _rootRt;

	[SerializeField]
	private RectTransform _adjustRt;

	[SerializeField]
	private RectTransform _animRt;

	[SerializeField]
	private SpriteRenderer _numberImage_10;

	[SerializeField]
	private SpriteRenderer _numberImage_01;

	[SerializeField]
	private SpriteRenderer _leftTextImage;

	[SerializeField]
	private SpriteRenderer _rightTextImage;

	[SerializeField]
	private TimeData[] _timeDataArray_jp;

	[SerializeField]
	private TimeData[] _timeDataArray_us;

	[SerializeField]
	private TimeData[] _timeDataArray_cn;

	[SerializeField]
	private TimeData[] _timeDataArray_tw;

	private RectTransform _numberImageRt_10;

	private RectTransform _numberImageRt_01;

	private RectTransform _leftTextImageRt;

	private RectTransform _rightTextImageRt;

	private VisibleUIObject _rootVisible;

	private Sequence _seqAnim;

	private float _lastTime;

	public static InGameScoringEventCountDownUI Create(GameObject parent, int siblingIndex = -1)
	{
		return null;
	}

	protected virtual void Initialize()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetTime(float time, bool isForce = false, bool isPlayAnim = true)
	{
	}

	private void PlayAnim10()
	{
	}

	private void PlayAnim01()
	{
	}

	private void OnUpdateAnim(float t, float startFade, float endFade, float startPosY, float endPosY)
	{
	}

	private void SetPosY(float value)
	{
	}

	private void SetFade(float value)
	{
	}

	private void SetFade(SpriteRenderer obj, float value)
	{
	}

	private TimeData[] GetTimeDataArray()
	{
		return null;
	}
}
