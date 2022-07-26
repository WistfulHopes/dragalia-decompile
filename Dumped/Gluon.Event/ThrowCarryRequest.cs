namespace Gluon.Event;

public class ThrowCarryRequest : EventBase<ThrowCarryRequest>
{
	public CharacterId thrower;

	public CharacterId target;

	public int sequenceId;
}
