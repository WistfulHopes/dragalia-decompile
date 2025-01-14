using System.Collections.Generic;

namespace Gluon;

public class MainGameRebornCtrl
{
	private class SystemRebornParam
	{
		public float rebornTimer;

		public int consumeRebornCount;

		public bool isRebornCountDown;
	}

	private class AbilityRebornParam
	{
		public float rebornTimer;

		public int usedRebornCount;

		public int rebornCountLimit;

		public bool isReserved;

		public bool isRebornCountDown;

		public float hpRate;

		public float consumeDpRate;
	}

	private class ActionRebornParam
	{
		public bool isReserved;

		public float hpRate;

		public bool withSpCharge;

		public float spChargeRate;
	}

	private SystemRebornParam _systemRebornParam;

	private Dictionary<CharacterSelector, AbilityRebornParam> _abilityRebornParamDic;

	private Dictionary<CharacterSelector, ActionRebornParam> _actionRebornParamDic;

	private InGameUICtrl uiCtrl;

	private CharacterManager charaManager;

	private GameDataManager gameDataManager;

	private InGameSettings settings;

	public MainGameRebornCtrl(GameDataManager gameDataManager, InGameSettings settings, CharacterManager charaManager, InGameUICtrl uiCtrl)
	{
	}

	public void OnContinue()
	{
	}

	public bool IsRebornableQuest()
	{
		return default(bool);
	}

	public void RegisterAbilityRebornParam(CharacterSelector owner, int rebornCount, float hpRate, float consumeDpRate)
	{
	}

	public void ReserveActionReborn(CharacterSelector owner, float hpRate, bool withSpCharge, float spChargeRate)
	{
	}

	public void Update()
	{
	}

	public bool UpdateAllDead()
	{
		return default(bool);
	}

	private bool UpdateSystemReborn()
	{
		return default(bool);
	}

	private void UpdateActionRebornAll()
	{
	}

	private void UpdateAbilityRebornAll()
	{
	}

	private void UpdateAbilityReborn(CharacterSelector selector, AbilityRebornParam param)
	{
	}

	private void UpdateActionReborn(CharacterSelector selector, ActionRebornParam param)
	{
	}

	public bool IsRemainAnyRebornCount()
	{
		return default(bool);
	}

	public bool IsAbilityRebornCountingDown()
	{
		return default(bool);
	}

	public bool IsActionRebornReserved()
	{
		return default(bool);
	}

	public bool IsActionRebornReserved(CharacterBase chara)
	{
		return default(bool);
	}

	private List<CharacterBase> GetSystemRebornTargetCharas()
	{
		return null;
	}

	public bool WillReborn(CharacterBase chara)
	{
		return default(bool);
	}

	public bool CanSystemReborn(CharacterBase chara)
	{
		return default(bool);
	}

	public bool CanAbilityReborn(CharacterBase chara)
	{
		return default(bool);
	}

	public int GetAnyRebornCount(CharacterBase chara)
	{
		return default(int);
	}

	public int GetSystemRebornCount(CharacterBase chara)
	{
		return default(int);
	}

	public int GetAbilityRebornCount(CharacterBase chara)
	{
		return default(int);
	}

	public void StartAbilityReborn(CharacterBase chara)
	{
	}

	private float GetCurrentDpRate()
	{
		return default(float);
	}

	private void CancelReborn()
	{
	}

	private void CancelReborn(CharacterSelector owner)
	{
	}
}
