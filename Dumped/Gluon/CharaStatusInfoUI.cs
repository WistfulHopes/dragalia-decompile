using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon;

public class CharaStatusInfoUI : FastUpdateMonoBehaviour
{
	[Serializable]
	public class DigitLayoutData
	{
		public float digitScale;

		public float digitOffsetX;

		public float signOffsetX;

		public float signOffsetY;

		public float signScale;
	}

	public enum ValueDisplayPositionType
	{
		Outside,
		Inside
	}

	[SerializeField]
	private RectTransform _rootRt;

	[SerializeField]
	private RectTransform _digitRootRt;

	[SerializeField]
	private RectTransform _signRt;

	[SerializeField]
	private SpriteRenderer _bgImage;

	[SerializeField]
	private SpriteRenderer _iconImage;

	[SerializeField]
	private SpriteRenderer _blinkIconImage;

	[SerializeField]
	private SpriteRenderer _gaugeImage;

	[SerializeField]
	private SpriteRenderer[] _digitImageList;

	[SerializeField]
	private SpriteRenderer _signImage;

	[SerializeField]
	private CircleGauge _gaugeCtrl;

	[SerializeField]
	private float _coolDownAlpha;

	[SerializeField]
	private int _playerSortingOrder;

	[SerializeField]
	private int _enemySortingOrder;

	[SerializeField]
	private DigitLayoutData[] _percentDigiLayoutDataArray;

	[SerializeField]
	private DigitLayoutData[] _countDigiLayoutDataArray;

	[SerializeField]
	private DigitLayoutData[] _quantityDigiLayoutDataArray;

	[SerializeField]
	private DigitLayoutData[] _levelDigiLayoutDataArray;

	[SerializeField]
	private DigitLayoutData[] _levelDigiLayoutDataArrayEN_US;

	[SerializeField]
	private Color _buffColor;

	[SerializeField]
	private Color _debuffColor;

	[SerializeField]
	private Color _auraColor;

	[SerializeField]
	private Color _partyAuraColor;

	private VisibleUIObject _rootVisible;

	private VisibleUIObject _digitRootVisible;

	private VisibleUIObject _signVisible;

	private VisibleUIObject[] _digitVisibleList;

	private VisibleUIObject _blinkIconVisible;

	private int _maxDigitNum;

	private int[] _maxNumList;

	private int _horizontalNum;

	private ValueDisplayPositionType _valueDispPosType;

	private int _index;

	private int _buffIconId;

	private AuraConst.TargetType _auraTargetType;

	private AuraType _auraType;

	private AbnormalStatusType _abnormalType;

	private EnemyAbilityType _enemyAbilityType;

	private int _productId;

	private int _value;

	private float _gaugeRate;

	private readonly float[] DigitAdjustRootPositionList;

	private const float IconMerginX = 45f;

	private const float IconMerginXForInside = 42f;

	private const float IconMerginY = 60f;

	public bool IsCoolDown
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

	public bool IsEnable
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

	public bool IsDirty
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

	public static CharaStatusInfoUI Create(GameObject parent, GameObject pobj, ValueDisplayPositionType type, int horizontalNum, int siblingIndex = -1)
	{
		return null;
	}

	private void Initialize(ValueDisplayPositionType type, int horizontalNum)
	{
	}

	private void SetMaxNum(InGameBuffUI.ValueDisplayType type, int digitNum)
	{
	}

	public void ResetData()
	{
	}

	public void Visible(bool b)
	{
	}

	public void ShowByBuff(int buffIconId, bool isBuff, InGameBuffUI.ValueDisplayType valueDispType, InGameBuffUI.GaugeDisplayType gaugeDispType, int productId, EnemyAbilityType enemyAbilityType, Sprite sprite, int count, int value, int level, int maxLevel, int index, int quantity, int durationNum, bool coolDown, int durationTimeScale)
	{
	}

	public void ShowByAbnormal(AbnormalStatusType type, Sprite sprite, int value, int index)
	{
	}

	public void ShowByAura(CharacterAuraCtrl.Parameter param, Sprite sprite, int index)
	{
	}

	private void SetEffectValue(InGameBuffUI.ValueDisplayType type, int value, Color color)
	{
	}

	public void SetGaugeRate(float rate, bool force = false)
	{
	}

	public void SetDirty(bool b)
	{
	}

	public bool IsMatch(int buffIconId, int productId)
	{
		return default(bool);
	}

	public bool IsMatch(AbnormalStatusType type)
	{
		return default(bool);
	}

	public bool IsMatch(EnemyAbilityType type)
	{
		return default(bool);
	}

	public bool IsMatch(AuraConst.TargetType targetType, AuraType type, int productId)
	{
		return default(bool);
	}

	public void AdjustRootPosition(int index)
	{
	}

	public void SetCoolDown(bool b, bool force = false)
	{
	}

	private void ApplyColorAlpha()
	{
	}

	private void ApplyColorAlpha(ref SpriteRenderer sprite)
	{
	}

	private DigitLayoutData[] GetLevelDigiLayoutDataArray()
	{
		return null;
	}

	public void SetVisibleBlinkIcon(bool b)
	{
	}

	public void OnUpdateBlinkAnim(float value)
	{
	}
}
