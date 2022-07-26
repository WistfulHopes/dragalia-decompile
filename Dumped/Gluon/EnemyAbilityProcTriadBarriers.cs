using Gluon.Master;
using UnityEngine;

namespace Gluon;

public class EnemyAbilityProcTriadBarriers : EnemyAbilityProcBase
{
	private enum BarrierType
	{
		AllDamage,
		ExceptCombo,
		ExceptBA
	}

	private EnemyAbilityProcTriadBarriers _linkedBarrier;

	private Transform _effAttachNode;

	public override string effKey => null;

	public EnemyAbilityProcTriadBarriers(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
	{
	}

	public override void Play()
	{
	}

	public override void Stop()
	{
	}

	public override void OnCharacterInit()
	{
	}

	public override void OnEntry()
	{
	}

	public override void OnUpdate()
	{
	}

	public override void OnCalcBaseDamageReceive(CollisionHitAttribute attr, DamageCalculation.DamageStatus.Type damageType, ref EnemyAbility.Argument arg)
	{
	}

	public override void OnCalcAbnormalSlipDamage(CharacterBase attacker, ref EnemyAbility.Argument arg)
	{
	}

	public override void OnCalcAdditionalDamage(ref EnemyAbility.Argument arg)
	{
	}

	public override void OnPlayQTECutt()
	{
	}

	public override void PlayEffect(EffectObject.FollowPosType followPos = EffectObject.FollowPosType.POSITION_GROUND)
	{
	}
}
