using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon;

public class SkillInfo : FastUpdateMonoBehaviour
{
	[SerializeField]
	private Button _button;

	[SerializeField]
	private RectTransform _offsetRt;

	[SerializeField]
	private RectTransform _effectRt;

	[SerializeField]
	private RectTransform _noUseRt;

	[SerializeField]
	private RectTransform _chainSkillFrameRt;

	[SerializeField]
	private SpriteRenderer _skillIcon;

	[SerializeField]
	private SpriteRenderer _effectImage;

	[SerializeField]
	private SpriteRenderer _chainSkillFrameImage;

	[SerializeField]
	private SpriteRenderer _infoIconImage;

	[SerializeField]
	private SkillIconCtrl _skillIconCtrl;

	[SerializeField]
	private InGameCounterUI _counterUI;

	[SerializeField]
	private SkillOverChargeGaugeUI _overChargeGaugeUI;

	[SerializeField]
	private float _expansionTime;

	[SerializeField]
	private float _maxGaugeAnimFlashPower;

	private RectTransform _rootRt;

	private RectTransform _infoIconRt;

	private Tweener _twExpansion;

	private VisibleUIObject _effectVisible;

	private VisibleUIObject _noUseVisible;

	private VisibleUIObject _chainSkillVisible;

	private float _gaugeRate;

	private float _lastGaugeRate;

	private bool _isValidate;

	private bool _isExpansionEffect;

	private bool _isMaxEffect;

	private bool _isGaugeMax;

	private int _spGaugeCount;

	private bool _isDisableRequiredBuff;

	private bool _isCharaEnableSkill;

	private bool _isDisableUpdate;

	private bool _isCheckActive;

	private bool _isEnableChainSkill;

	private int _lastSkillId;

	private string _lastIconName;

	private const float TweenerExpansionEndValue = 1f;

	private const int EmptyItemSkillID = -1;

	[HideInInspector]
	public int skillIndex => default(int);

	[HideInInspector]
	public int skillSlot
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Initialize(Action<SkillInfo> onClick, int skillSlot, bool isLeft)
	{
	}

	public override void FastUpdate()
	{
	}

	public bool SetSkillIcon(CharacterBase chara, int skillId, bool isForce = false)
	{
		return default(bool);
	}

	public bool SetEmptyItemSkillIcon(CharacterBase chara, bool isDisable = true, bool isForce = false)
	{
		return default(bool);
	}

	public void DisableSkill(bool isDisable, bool isDisableGrayOut, bool isEnableReturnValue)
	{
	}

	private void SetSkillIcon(string iconName, Material material, Sprite sprite)
	{
	}

	public void SetItemSkillCount(int count)
	{
	}

	public void SetGaugeValue(float rate, bool isForce = false)
	{
	}

	public void SetOverChargeGaugeValue(int phase, int phaseSp, int phaseConsumeSp, bool isForce = false)
	{
	}

	public void SetOverChargeGaugeValueForConsumeCp(float rate, bool isForce = false)
	{
	}

	private void CheckInactive(bool bmax)
	{
	}

	public void Attach(RectTransform parentRT)
	{
	}

	public void Visible(bool b, bool force = false)
	{
	}

	public bool IsVisible()
	{
		return default(bool);
	}

	public void Validate(bool b)
	{
	}

	public Vector2 GetButtonPosition()
	{
		return default(Vector2);
	}

	public Vector2 GetButtonSize()
	{
		return default(Vector2);
	}

	private void StartExpansionEffect()
	{
	}

	private void OnUpdateExpansion(float value)
	{
	}

	private void OnCompleteExpansion()
	{
	}

	public void PauseMaxEffect()
	{
	}

	public void SetEnabled(bool b)
	{
	}

	public void OnUpdateGaugeMax(float value)
	{
	}

	public void SetupChainSkill(Material frameMat)
	{
	}

	public void SetVisibleChainSkill(bool b)
	{
	}

	public void SetDisableSkillByRequiredBuff(bool v, int spGaugeCount)
	{
	}
}
