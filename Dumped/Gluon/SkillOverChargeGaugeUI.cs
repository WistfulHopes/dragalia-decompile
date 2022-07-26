using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon;

public class SkillOverChargeGaugeUI : FastUpdateMonoBehaviour
{
	[Serializable]
	private class LoopColorData
	{
		[SerializeField]
		private Color _startColor;

		[SerializeField]
		private Color _endColor;

		public Color startColor => default(Color);

		public Color endColor => default(Color);

		public LoopColorData(Color start, Color end)
		{
		}
	}

	[Serializable]
	private class LoopFadeData
	{
		[SerializeField]
		private float _startFade;

		[SerializeField]
		private float _endFade;

		public float startFade => default(float);

		public float endFade => default(float);

		public LoopFadeData(float start, float end)
		{
		}
	}

	[SerializeField]
	private RectTransform _maxChargeAnimRt;

	[SerializeField]
	private RectTransform _lineRootRt;

	[SerializeField]
	private RectTransform _lineTopRt;

	[SerializeField]
	private RectTransform _lineBottomRt;

	[SerializeField]
	private RectTransform _originLineRt;

	[SerializeField]
	private RectTransform _gaugeMaskRt;

	[SerializeField]
	private SpriteRenderer _gaugeSprite;

	[SerializeField]
	private SpriteRenderer _maxGaugeEffectSprite;

	[SerializeField]
	private SpriteRenderer _maxGaugeEffectSprite2;

	[SerializeField]
	private SpriteRenderer _maxGaugeEffectSprite3;

	[SerializeField]
	private SpriteRenderer _maxGaugeFrameEffectSprite;

	[SerializeField]
	private SpriteRenderer _maxGaugeGradationEffectSprite;

	[SerializeField]
	private Color[] _subGaugeColor;

	[SerializeField]
	private Color[] _effectColor;

	[SerializeField]
	private Color[] _gradationEffectColor;

	[SerializeField]
	private LoopColorData[] _frameEffectLoopColor;

	[SerializeField]
	private LoopColorData _maxGaugeSubGaugeLoopColor;

	[SerializeField]
	private LoopColorData _maxGaugeSubGaugeLoopColorForConsumeCp;

	[SerializeField]
	private LoopFadeData _maxGaugeEffectLoopFade;

	private RectTransform _maxGaugeEffectRt;

	private RectTransform _maxGaugeEffectRt2;

	private RectTransform _maxGaugeEffectRt3;

	private RectTransform _maxGaugeFrameEffectRt;

	private RectTransform _maxGaugeGradationEffectRt;

	private VisibleUIObject _rootVisible;

	private List<RectTransform> _lineRtList;

	private Sequence _seqMaxGauge;

	private Sequence _seqMaxSubGauge;

	private int _divisionNum;

	private int _lineNum;

	private int _skillIndex;

	private int _effectPhaseIndex;

	private float _gaugeRate;

	private float _maxSubGaugeRate;

	public bool isConsumeCp
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

	public void Initialize(int skillIndex)
	{
	}

	private void OnDestroy()
	{
	}

	public void SetupLine()
	{
	}

	public void SetupLine(int divisionNum)
	{
	}

	public override void FastUpdate()
	{
	}

	public void SetLineNum(CharacterBase chara)
	{
	}

	public void SetGaugeRate(int phase, int phaseSp, int phaseConsumeSp, bool isPlayAnim = true, bool isForce = false)
	{
	}

	public void SetGaugeRate(float rate, bool isPlayAnim = true, bool isForce = false)
	{
	}

	private bool IsMomentMaxGauge(float rate)
	{
		return default(bool);
	}

	private bool IsMomentMaxSubGauge(float rate)
	{
		return default(bool);
	}

	private bool IsMomentStepOverSubGauge(float rate)
	{
		return default(bool);
	}

	public void ApplyGaugeColor()
	{
	}

	public void ApplyEffectColor()
	{
	}

	public void ApplyLineVisible()
	{
	}

	public void SetVisible(bool b)
	{
	}

	public bool IsVisible(bool b = false)
	{
		return default(bool);
	}

	public void PlayMaxGauge()
	{
	}

	public void PlayMaxSubGauge(bool isMaxGauge)
	{
	}

	public void OnUpdateMaxGauge(float t)
	{
	}
}
