using System;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon;

public class CharaGimmickGunChargeGaugeUI : CharaGimmickBaseGaugeUI
{
	public enum StateType
	{
		Charge,
		Discharge
	}

	protected enum GaugeType
	{
		Charge,
		ChargeMax
	}

	protected class CustomPointData
	{
		public int prevCP;

		public int currCP;

		public bool isUsed;

		public bool Set(int prevCP, int currCP)
		{
			return default(bool);
		}

		public void Clear()
		{
		}
	}

	[SerializeField]
	protected RectTransform _rootRt;

	[SerializeField]
	protected RectTransform _adjustRt;

	[SerializeField]
	protected InGameSimpleGaugeUI _chargeGauge;

	[SerializeField]
	protected InGameSimpleGaugeUI _dischargeGauge;

	[SerializeField]
	protected SpriteRenderer _sandTimerImage;

	[SerializeField]
	protected InGameCounterUI _chargeCounter;

	[SerializeField]
	protected InGameSimpleGaugeUI[] _bulletGauge;

	[SerializeField]
	protected Color32[] _gaugeColor;

	[SerializeField]
	protected int _maxStackNum;

	[SerializeField]
	protected float _dischargeChangeBulletDelayAnimTime;

	protected VisibleUIObject _visible;

	protected VisibleUIObject _sandTimerVisible;

	protected VisibleUIObject _countVisible;

	protected HumanCharacter _owner;

	protected List<AbilityDataElement> _abilityList;

	protected StateType _state;

	protected int _targetCountValue;

	protected float _targetChargeGaugeRate;

	protected List<List<CustomPointData>> _targetCPDataList;

	protected int _lastCountValue;

	protected float _lastChargeGaugeRate;

	protected float _lastDischargeGaugeRate;

	protected int _lastCP;

	protected int _overflowCount;

	protected int _cpIndex;

	protected Action<int, int, int> _onStepoverCallback;

	protected int _stepoverCallbackArgeIndex;

	protected readonly CharacterBuffType TargetBuffType;

	protected readonly int TargetBuffIconId;

	protected readonly int CPDataReserveNum;

	public static CharaGimmickGunChargeGaugeUI Create(CharacterBase chara, GameObject parent, int siblingIndex = -1)
	{
		return null;
	}

	protected virtual void Initialize(CharacterBase chara)
	{
	}

	private void OnDestroy()
	{
	}

	public override void FastUpdate()
	{
	}

	protected void UpdateUI(bool isForce = false)
	{
	}

	private void UpdateChargeModeUI(int buffNum, float durationTime, float lifeTime, bool isForce)
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public override bool IsVisible()
	{
		return default(bool);
	}

	public override void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false, bool isForce = false)
	{
	}

	protected bool AddCPData(int index, int prevCP, int currCP)
	{
		return default(bool);
	}

	protected bool SetState(StateType state, bool isForce = false, bool isAnim = true)
	{
		return default(bool);
	}

	private void SetCountValue(int stack, bool isForce = false, bool isAnim = true)
	{
	}

	public void SetChargeGaugeRate(float chargeRate, int chargeCount, int overflowCount, bool isForce = false)
	{
	}

	public void SetDischargeGaugeRate(float timeRate, bool isForce = false)
	{
	}

	public override void SetAbilityData(ref List<AbilityDataElement> list)
	{
	}

	public override void SetGaugeAnimCompleteCallback(int idx, Action<int, int, int> onComplete)
	{
	}

	protected void ApplyGaugeCallback(int index)
	{
	}

	protected void ApplyGaugeCallback()
	{
	}

	public override int GetGaugeType()
	{
		return default(int);
	}
}
