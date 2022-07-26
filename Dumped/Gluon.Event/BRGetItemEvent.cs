namespace Gluon.Event;

public class BRGetItemEvent : EventBase<BRGetItemEvent>
{
	public BRItemId target;

	public CharacterId getter;
}
