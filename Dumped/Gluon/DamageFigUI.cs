using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon;

public class DamageFigUI : FastUpdateMonoBehaviour
{
	public enum NoDamageType
	{
		Resist,
		Miss,
		Guard,
		Dodge,
		ODCounter
	}

	private enum Location
	{
		Center,
		Bottom
	}

	[Serializable]
	private class TextData
	{
		public Sprite sprite;

		public float margin;
	}

	[Serializable]
	private class DamageAnim
	{
		public float delayTime;

		public float[] initScaleY;

		public float[] scaleY;

		public float moveY;

		public float intervalDuration;

		public float intervalDurationCritical;

		public float intervalDurationTotal;
	}

	private class AnimObject
	{
		private DamageFigUI owner;

		private Transform rootTrans;

		private SpriteRenderer image;

		private float baseScale;

		private Vector3 parentInitPos;

		private int animPhase;

		private float animTime;

		private float animDelayTime;

		private float animIntervalTime;

		public bool isPlaying
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

		public AnimObject(DamageFigUI owner, Transform rootTrans, SpriteRenderer image, int idx)
		{
		}

		public void StopAnim()
		{
		}

		public void SetBaseScale(float scale)
		{
		}

		public float InitAnim(float delayTime, float intervalTime)
		{
			return default(float);
		}

		public float UpdateAnim(float deltaTime, bool isApply = true)
		{
			return default(float);
		}
	}

	[SerializeField]
	private Transform rtWord;

	[SerializeField]
	private SpriteRenderer[] imageFig;

	[SerializeField]
	private TextData[] resistTextDataArray;

	[SerializeField]
	private TextData[] missTextDataArray;

	[SerializeField]
	private TextData[] guardTextDataArray;

	[SerializeField]
	private TextData[] dodgeTextDataArray;

	[SerializeField]
	private TextData[] odCounterTextDataArray;

	[SerializeField]
	private float correctRadius;

	[SerializeField]
	private DamageAnim damageAnim;

	private static readonly float[] pivotLocationTransform;

	private const int figCount = 8;

	private const float figScale = 100f;

	private RectTransform rootRt;

	private Transform[] figRt;

	private AnimObject[] figAnimObj;

	private CanvasGroup canvasGroup;

	private Tweener twFade;

	private InGameUICtrl inGameUI;

	private bool isVisible;

	public static DamageFigUI Create(GameObject parent, GameObject target, InGameUICtrl inGameUI)
	{
		return null;
	}

	private void Initialize(InGameUICtrl inGameUI)
	{
	}

	public override void FastUpdate()
	{
	}

	private void Visible(bool b, bool force = false)
	{
	}

	public void SetupNoDamage(Vector3 position, NoDamageType noDamageType, Color color)
	{
	}

	private int SetupWord(NoDamageType word, Color color)
	{
		return default(int);
	}

	private void DisableObject(bool b)
	{
	}

	private void StopTween()
	{
	}

	public void StopAllImmediate()
	{
	}

	private void SetPivotTransform(int n, Transform[] rt, Location loc)
	{
	}

	private float SetDamageAnim(int wordNum, AnimObject[] tweenObject, bool reverse)
	{
		return default(float);
	}

	private void OnCompleteFade1()
	{
	}

	private void DelayedCall(float delay, TweenCallback onComplete)
	{
	}

	private void SetVisibleFigImage(bool visible)
	{
	}

	private void SetFade(float fade)
	{
	}
}
