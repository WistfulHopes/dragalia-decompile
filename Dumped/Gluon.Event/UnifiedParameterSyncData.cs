namespace Gluon.Event;

public struct UnifiedParameterSyncData
{
	public int multiPlayKey;

	[ActionConditionId]
	public int conditionId;

	public float durationSec;

	public short durationNum;

	public int skillId;

	public int actionId;

	public int abilityId;

	public int productId;

	public byte hitTargetGroup;

	public CharacterId from;

	public float sacrificeShieldConsumeHp;
}
