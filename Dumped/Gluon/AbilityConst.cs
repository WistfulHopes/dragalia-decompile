namespace Gluon;

public static class AbilityConst
{
	public enum Type
	{
		None,
		StatusUp,
		ResistAbs,
		ActAddAbs,
		ResistTribe,
		ActKillerTribe,
		ActDamageUp,
		ActCriticalUp,
		ActRecoveryUp,
		ActBreakUp,
		ResistTrap,
		AddRecoverySp,
		AddRecoveryDp,
		RecoveryHpOnHitCount,
		ChangeState,
		ResistInstantDeath,
		DebuffGrantUp,
		SpCharge,
		BuffExtension,
		DebuffExtension,
		AbnormalKiller,
		UserExpUp,
		CharaExpUp,
		CoinUp,
		ManaUp,
		ActionGrant,
		CriticalDamageUp,
		DpCharge,
		ResistElement,
		ResistUnique,
		UniqueKiller,
		Dummy01,
		Dummy02,
		Dummy03,
		Dummy04,
		ModeGaugeSuppression,
		DragonDamageUp,
		EnemyAbilityKiller,
		HitAttribute,
		PassiveGrant,
		ActiveGaugeStatusUp,
		Dummy05,
		HitAttributeShift,
		ReferenceOther,
		EnhancedSkill,
		EnhancedBurstAttack,
		DragonTimeForParty,
		AbnoramlExtension,
		DragonTimeSpeedRate,
		DpChargeMyParty,
		DontAct,
		RandomBuff,
		CriticalUpDependsOnBuffTypeCount,
		InvalidDragonAbility,
		ActDamageUpDependsOnHitCount,
		ChainTimeExtension,
		UniqueTransform,
		EnhancedElementDamage,
		UtpCharge,
		DebuffTimeExtensionForSpecificDebuffs,
		RemoveAllStockBullets,
		ChangeMode,
		RandomBuffNoTDuplicate_Param1Times,
		ModifyBuffDebuffDurationTime,
		CpCoef,
		UniqueAvoid,
		RebornHpRateUp,
		AttackBaseOnHPUpRate,
		ChangeStateHostile,
		CpContinuationDown,
		AddCpRate,
		RunOptionAction,
		SecondElements,
		KickAuraEffectTritter,
		ConsumeSpToRecoverHp,
		CrestGroupScoreUp,
		ModifyBuffDebuffDurationTimeByRecoveryHp,
		CrisisRate,
		ActDamageDown,
		AutoAvoidProbability,
		LimitCriticalAddRate,
		AddReborn,
		RunOptionActionRemoteToo,
		ConsumeUtpToRecoverHp,
		DpGaugeCap,
		AbnormalTypeNumKiller,
		RegisterKeepComboAction,
		NotUpdateDragonTime,
		SetCharacterState,
		ChangeModeRemoteToo,
		RecoverySpCutRate,
		ActRecoveryMulForDyingTarget,
		CallCpCommand,
		AdditionalHitCollision,
		RecoveryOnDamage,
		Guts,
		SendSignal,
		RemoveSignal,
		StatusUpBaseOnCharaType,
		ChangeStateOtherPartyMembers,
		DpGaugeCap2,
		DpChargeMyParty2,
		Reserved_102,
		Reserved_103,
		Reserved_104,
		Reserved_105,
		Reserved_106,
		Reserved_107,
		Reserved_108,
		Reserved_109,
		Reserved_110
	}

	public enum TargetParam
	{
		None,
		Hp,
		Atk,
		Def,
		Spr,
		Dpr,
		Dummy1,
		ChargeTime,
		DragonTime,
		DamageCut,
		AttackSpeed,
		BurstSpeed,
		ChargeSpeed,
		ConsumeDpRate,
		FinalDragonTimeRate,
		Utpr,
		DamageCutB,
		MoveSpeedRateB,
		NeedDpRate,
		MoveSpeedRateC
	}

	public enum BuffType
	{
		None = 0,
		Hp = 1,
		Attack = 2,
		Defense = 3,
		Critical = 4,
		SkillPower = 5,
		BurstPower = 6,
		Recovery = 7,
		AttackSpeed = 8,
		All = 99
	}

	public enum UnitType
	{
		None,
		Chara,
		Dragon,
		Amulet,
		Weapon,
		Skill,
		ExAbility2,
		EventAbility,
		UnionBonus,
		Talisman
	}

	public enum ExpireType
	{
		None,
		DamagedAbs
	}

	public enum HitAttributeShiftCondition
	{
		None,
		DragonTransformCount
	}

	public enum SkillOwner
	{
		Human = 1,
		Dragon = 2,
		Weapon = 4,
		HumanOrigin = 8
	}

	public const int humanSlotMax = 3;

	public const int dragonSlotMax = 2;

	public const int amuletSlotMax = 2;

	public const int talismanSlotMax = 3;

	public const int weaponSlotMax = 2;

	public const int exAbility2SlotMax = 4;

	public const int eventAbilitySlotMax = 2;

	public const int capacityMax = 3;

	public const int shiftLvMax = 8;

	public static readonly bool[] NeedApplyConditionallyToOtherPlayers;
}
