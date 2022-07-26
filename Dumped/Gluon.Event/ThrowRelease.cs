namespace Gluon.Event;

public class ThrowRelease : EventBase<ThrowRelease>
{
	public CharacterId thrower;

	public CharacterId target;

	public bool isThrow;

	public int sequenceId;
}
