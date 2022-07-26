using Gluon.Master;

namespace Gluon;

public class EnemyAbilityProcDamageLimit : EnemyAbilityProcBase
{
	public EnemyAbilityProcDamageLimit(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
	{
	}

	public override void OnCalcFinalDamageReceive(ref EnemyAbility.Argument arg)
	{
	}

	public override void OnApplySlipDamage(ref EnemyAbility.Argument arg, ref int damage, AbnormalStatusType abnormalStatusType, CharacterBuffType buffType)
	{
	}

	public override void OnCalcFinalBuffExtraDamage(ref EnemyAbility.Argument arg)
	{
	}

	public override void OnCalcFinalAdditionalDamage(ref EnemyAbility.Argument arg)
	{
	}

	private int CalcLimitDamageCorrection(int damage)
	{
		return default(int);
	}
}
