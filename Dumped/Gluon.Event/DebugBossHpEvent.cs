namespace Gluon.Event;

public class DebugBossHpEvent : EventBase<DebugBossHpEvent>
{
	[Required]
	public CharacterId[] targets;

	[Required]
	public int[] hp;
}
