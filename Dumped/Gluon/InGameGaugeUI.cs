using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class InGameGaugeUI : FastUpdateMonoBehaviour
{
	[SerializeField]
	private GameObject rootObj;

	[SerializeField]
	private Image bgImage;

	[SerializeField]
	private RectTransform lossMask;

	[SerializeField]
	private Image lossBar;

	[SerializeField]
	private RectTransform gainMask;

	[SerializeField]
	private Image gainBar;

	[SerializeField]
	private RectTransform baseMask;

	[SerializeField]
	private Image baseBar;

	[SerializeField]
	private Image blinkImage;

	[SerializeField]
	private Sprite[] bgSprite;

	[SerializeField]
	private bool useGaugeSprite;

	[SerializeField]
	private Sprite[] gaugeSprite;

	[SerializeField]
	private Color baseColor;

	[SerializeField]
	private Color maxColor;

	[SerializeField]
	private Color dyingColor;

	[SerializeField]
	private Color incColor;

	[SerializeField]
	private Color decColor;

	[SerializeField]
	private Color blinkColor0;

	[SerializeField]
	private Color blinkColor1;

	[SerializeField]
	private bool isMaskedSprite;

	[SerializeField]
	private float initialValue;

	[SerializeField]
	private float dyingRate;

	[SerializeField]
	private float waitTime;

	[SerializeField]
	private float diffMoveTime;

	[SerializeField]
	private float blinkTime;

	private RectTransform lossBarRT;

	private RectTransform gainBarRT;

	private RectTransform baseBarRT;

	private GameObject blinkGameObj;

	private Vector2 gaugeSize;

	private float gaugeWidth;

	private float lossRemainTime;

	private float gainRemainTime;

	private float lastValue;

	private Color srcColor;

	private Color blinkColor;

	private Tweener blinkTweener;

	private VisibleUIObject rootVisible;

	private VisibleUIObject lossVisible;

	private VisibleUIObject gainVisible;

	private VisibleUIObject baseVisible;

	private VisibleUIObject blinkVisible;

	public float BlinkValue
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Initialize()
	{
	}

	public override void FastUpdate()
	{
	}

	public void SetValue(float value, bool immediate)
	{
	}

	public float GetValue()
	{
		return default(float);
	}

	public bool IsDying()
	{
		return default(bool);
	}

	public bool IsMax()
	{
		return default(bool);
	}

	public void Visible(bool value)
	{
	}

	public bool IsVisible()
	{
		return default(bool);
	}

	public bool IsChanging()
	{
		return default(bool);
	}

	public void SetBlink(bool on, int index = 0)
	{
	}

	public bool IsBlink()
	{
		return default(bool);
	}

	private void SetBarSize(float value)
	{
	}

	private void SetGainMaskSize(float value)
	{
	}

	private void SetBaseMaskSize(float value)
	{
	}

	private float GetBarValue()
	{
		return default(float);
	}

	private float GetBaseMaskValue()
	{
		return default(float);
	}

	private bool WaitTime(ref float t, ref float remainTime)
	{
		return default(bool);
	}

	private void SetBaseColor(Color color)
	{
	}

	private void SetBGSprite(int idx)
	{
	}

	private void SetBaseSprite(int idx)
	{
	}

	private void StartBlink()
	{
	}

	private void StopBlink()
	{
	}

	private void OnUpdateBlink(float v)
	{
	}
}
