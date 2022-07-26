using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;

namespace Gluon;

public class UiAnimationHide : MonoBehaviour
{
	private enum MoveDirection
	{
		UP,
		Down,
		Right,
		Left
	}

	private enum UiCondition
	{
		Show,
		Move,
		Hide
	}

	[Serializable]
	private class AnimationUi
	{
		public GameObject obj;

		public int moveOrder;

		public MoveDirection moveDirection;

		[NonSerialized]
		public Vector3 defaultPos;

		[NonSerialized]
		public UiCondition condition;
	}

	[SerializeField]
	private int interval;

	[SerializeField]
	private float duration;

	[SerializeField]
	private float moveMargin;

	[SerializeField]
	private Ease enterEase;

	[SerializeField]
	private Ease exitEase;

	[SerializeField]
	private int headerMoveOrder;

	[SerializeField]
	private int footerMoveOrder;

	[SerializeField]
	private RectTransform parentObject;

	[SerializeField]
	private AnimationUi[] animationObjects;

	private int timingCount;

	private void Start()
	{
	}

	public void OnUiHideButtonPressed()
	{
	}

	public void OnFinishUiHideButtonPressed()
	{
	}

	private IEnumerator StartSlideOut()
	{
		return null;
	}

	private IEnumerator StartSlideIn()
	{
		return null;
	}

	private void SlideOut(AnimationUi ui)
	{
	}

	private void SlideIn(AnimationUi ui)
	{
	}

	private Vector3 GetToPosition(AnimationUi ui, RectTransform rectTransform)
	{
		return default(Vector3);
	}

	public bool IsMove()
	{
		return default(bool);
	}
}
