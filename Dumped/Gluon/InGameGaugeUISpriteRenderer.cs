using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon;

public class InGameGaugeUISpriteRenderer : FastUpdateMonoBehaviour
{
	[Serializable]
	public class GaugeColorData
	{
		public Color baseColor;

		public Color maxColor;

		public Color dyingColor;

		public Color incColor;

		public Color decColor;

		public Color blinkColor0;

		public Color blinkColor1;
	}

	private enum BaseGaugeSpriteType
	{
		Normal,
		Dying,
		Max
	}

	private enum BgSpriteType
	{
		Normal,
		Dying
	}

	[SerializeField]
	private GameObject rootObj;

	[SerializeField]
	private SpriteRenderer bgImage;

	[SerializeField]
	private Transform lossMask;

	[SerializeField]
	private SpriteRenderer lossBar;

	[SerializeField]
	private Transform gainMask;

	[SerializeField]
	private SpriteRenderer gainBar;

	[SerializeField]
	private Transform baseMask;

	[SerializeField]
	private SpriteRenderer baseBar;

	[SerializeField]
	private SpriteRenderer blinkImage;

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
	private GaugeColorData[] gaugeColorList;

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

	[SerializeField]
	private bool isNineSlice;

	[SerializeField]
	private bool isNineSliceGraduationRound;

	[SerializeField]
	private float nineSliceGraduationSize;

	private Transform lossBarRT;

	private Transform gainBarRT;

	private Transform baseBarRT;

	private GameObject blinkGameObj;

	private Vector3 gaugeSize;

	private float gaugeWidth;

	private float lossRemainTime;

	private float gainRemainTime;

	private float lastRate;

	private int maxNineSliceGraduationNum;

	private int gaugeColorIndex;

	private Color gaugeBaseColor;

	private Color gaugeMaxColor;

	private Color gaugeDyingColor;

	private Color gaugeIncColor;

	private Color gaugeDecColor;

	private Color gaugeBlinkColor0;

	private Color gaugeBlinkColor1;

	private Color changeColor;

	private Color baseOrgColor;

	private Color blinkOrgColor;

	private Tweener blinkTweener;

	private VisibleUIObject rootVisible;

	private bool bgImageEnabled;

	private bool lossBarEnabled;

	private bool gainBarEnabled;

	private bool baseBarEnabled;

	private bool blinkImageEnabled;

	private bool isChangeColor;

	private bool isDying;

	public Action<float> onComplete
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

	public float WaitTime => default(float);

	public float DiffMoveTime => default(float);

	public float BlinkTime => default(float);

	public void Initialize()
	{
	}

	public override void FastUpdate()
	{
	}

	public void SetGaugeColor(int gaugeColorIndex, bool immediate = false)
	{
	}

	public void SetValue(float value, bool immediate, bool ignoreValueApproximately = false)
	{
	}

	public float GetLastRate()
	{
		return default(float);
	}

	public float GetCurrentRate()
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

	private void SetLossMaskSize(float value)
	{
	}

	private void SetGainMaskSize(float value)
	{
	}

	private void SetBaseMaskSize(float value)
	{
	}

	private float GetBaseMaskRate()
	{
		return default(float);
	}

	public float GetGainMaskRate()
	{
		return default(float);
	}

	public float GetLossMaskRate()
	{
		return default(float);
	}

	public float GetBaseMaskValue()
	{
		return default(float);
	}

	public float GetGainMaskValue()
	{
		return default(float);
	}

	private bool UpdateWaitTime(ref float t, ref float remainTime)
	{
		return default(bool);
	}

	private void SetBaseColor(Color color)
	{
	}

	private void SetBGSprite(BgSpriteType type)
	{
	}

	private void SetBaseGaugeSprite(BaseGaugeSpriteType type)
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

	private void SetVisibleSpriteRenderer()
	{
	}

	public void SetDiffMoveTime(float time)
	{
	}

	public void SetChangeColor(Color color)
	{
	}

	public void SetChangeColorFlag(bool change, bool force = false)
	{
	}

	private void ApplyChangeColor(bool change)
	{
	}

	private Color GetGaugeBaseColor()
	{
		return default(Color);
	}

	public void SetGaugeBaseColor(Color color, bool force = false)
	{
	}

	private Color GetGaugeMaxColor()
	{
		return default(Color);
	}

	public void SetGaugeMaxColor(Color color, bool force = false)
	{
	}

	private Color GetGaugeDyingColor()
	{
		return default(Color);
	}

	private Color GetGaugeIncColor()
	{
		return default(Color);
	}

	private Color GetGaugeDecColor()
	{
		return default(Color);
	}

	private Color GetGaugeBlinkColor0()
	{
		return default(Color);
	}

	private Color GetGaugeBlinkColor1()
	{
		return default(Color);
	}

	public float GetGaugeMoveTime()
	{
		return default(float);
	}

	public float GetGaugeWaitTime()
	{
		return default(float);
	}

	public float GetGaugeDiffMoveTime()
	{
		return default(float);
	}
}
