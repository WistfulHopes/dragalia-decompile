namespace Gluon.Event;

public class PlayerEvent : EventBase<PlayerEvent>
{
	public enum PlayerEventTypes : byte
	{
		UpdateAllDeadConfirmed
	}

	public PlayerEventTypes type;

	public bool flag;
}
