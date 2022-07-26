namespace Gluon.Event;

public class BRNotifyEvent : EventBase<BRNotifyEvent>
{
	public enum BRNotifyEventTypes
	{
		GameEnd,
		PulseRadius,
		LevelUp,
		LookingCharacter,
		Extra
	}

	[Required]
	public BRNotifyEventTypes type;

	public BRNotifyEventParamBase param;
}
