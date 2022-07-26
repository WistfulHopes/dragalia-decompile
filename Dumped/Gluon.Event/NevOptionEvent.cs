namespace Gluon.Event;

public class NevOptionEvent : EventBase<NevOptionEvent>
{
	public enum NevOptionEventTypes
	{
		OnShootOption,
		AppearNevOption
	}

	[Required]
	public NevOptionEventTypes type;

	[Required]
	public CharacterId target;

	public NevOptionEventParamBase param;
}
