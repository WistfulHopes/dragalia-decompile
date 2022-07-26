namespace Gluon.Event;

public struct ParameterSyncData
{
	public int multiPlayKey;

	public byte type;

	[ActionConditionId]
	public int conditionId;

	public float durationSec;

	public short durationNum;

	public int skillId;

	public int actionId;

	public int abilityId;

	public int productId;

	public float rate;

	public byte hitTargetGroup;

	public CharacterId from;

	public float sacrificeShieldConsumeHp;
}
