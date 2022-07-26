namespace Gluon.Event;

public class ApplyAbilityEvent : EventBase<ApplyAbilityEvent>
{
	[Required]
	public CharacterId owner;

	public int abilityId;

	public int idx;

	public int count;
}
