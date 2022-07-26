using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Master;

namespace Gluon;

public class CharacterCustomPointController_C4 : CharacterCustomPointController
{
	public enum CommandType
	{
		None,
		Die,
		FullHP
	}

	private float damageOverRatio;

	private List<int> leveledIds;

	private int deathActionId;

	private int costLifeActionId;

	protected override void Initialize(CharacterBase owner, AbilityDataElement[] elems)
	{
	}

	private void ResetHp()
	{
	}

	public int GetLifeLevel()
	{
		return default(int);
	}

	public bool HasConditionId(int conditionId)
	{
		return default(bool);
	}

	public override int OnDamageApplied(int damage, bool isAnnihilationAttack, bool isSlipDamage, bool isSelfDamage, [Optional] CharacterDamageIntermediate intermediate)
	{
		return default(int);
	}

	public override float OverrideCrisisRate(float crisisRate)
	{
		return default(float);
	}

	public override bool OnCommand(int commandType, int param, CharacterBase aboutChara)
	{
		return default(bool);
	}
}
