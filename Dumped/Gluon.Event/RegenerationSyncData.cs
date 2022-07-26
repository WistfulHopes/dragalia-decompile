namespace Gluon.Event;

public struct RegenerationSyncData
{
	public int multiPlayKey;

	[ActionConditionId]
	public int conditionId;

	public float healValue1;

	public float healValue2;

	public float healValue3;

	public float durationSec;

	public int abilityId;

	public CharacterId from;

	public int productId;

	public byte hitTargetGroup;

	public int skillId;

	public float healValue4;

	public int slipDamageGroup;

	public float rateIncreaseByTime;

	public float increaseRate;

	public int actionId;
}
