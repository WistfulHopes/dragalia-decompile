namespace Gluon.Event;

public struct GrantSyncData
{
	public int multiPlayKey;

	public byte trigger;

	[ActionConditionId]
	public int conditionId;

	public float durationSec;

	public int attribute;

	public int abilityId;
}
