namespace Gluon.Event;

public class ThrowCarryReply : EventBase<ThrowCarryReply>
{
	public CharacterId thrower;

	public CharacterId target;

	public bool isAccepted;

	public int sequenceId;
}
