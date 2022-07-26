namespace Gluon.Event;

public class VesselBombEvent : EventBase<VesselBombEvent>
{
	public enum VesselBombEventTypes
	{
		Countdown,
		CountdownWithCoolTime,
		Resisted
	}

	public VesselBombEventTypes EventVesselBombEventType;

	[Required]
	public CharacterId target;

	public int dungeonPartyIndex;

	public VesselBombEventParameterBase param;
}
