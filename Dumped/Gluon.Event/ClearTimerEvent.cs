namespace Gluon.Event;

public class ClearTimerEvent : EventBase<ClearTimerEvent>
{
	public enum EventTypes
	{
		Start,
		Pause,
		Restart
	}

	[Required]
	public EventTypes eventType;
}
