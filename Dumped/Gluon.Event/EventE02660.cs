namespace Gluon.Event;

public class EventE02660 : EventBase<EventE02660>
{
	[Required]
	public CharacterId[] boundChrs;

	public CharacterId ownerId;

	public int actionId;

	public short actionPartsIndex;
}
