namespace Gluon.Event;

public class ElectrifyEvent : EventBase<ElectrifyEvent>
{
	public CharacterId character;

	public int stackCount;

	public int state;
}
