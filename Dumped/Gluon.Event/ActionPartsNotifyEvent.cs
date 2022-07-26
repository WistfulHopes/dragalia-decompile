namespace Gluon.Event;

public class ActionPartsNotifyEvent : EventBase<ActionPartsNotifyEvent>
{
	public enum ActionPartsNotifyEventTypes
	{
		GozTackleInit,
		GozTackleTarget
	}

	[Required]
	public ActionPartsNotifyEventTypes type;

	[Required]
	public CharacterId target;

	public ActionPartsNotifyEventParamBase param;
}
