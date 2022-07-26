namespace Gluon.Event;

public class TriggerAbility : EventBase<TriggerAbility>
{
	public AbilityCondition conditionType;

	public CharacterId owner;

	public CharacterId from;

	public CharacterId target;

	public int actionId;

	public int skillId;
}
