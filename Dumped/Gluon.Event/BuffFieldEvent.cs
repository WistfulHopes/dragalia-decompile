namespace Gluon.Event;

public class BuffFieldEvent : EventBase<BuffFieldEvent>
{
	public enum BuffFieldEventTypes
	{
		Create,
		Delete
	}

	[Required]
	public BuffFieldEventTypes type;

	[Required]
	public long buffFieldId;

	[Required]
	public CharacterId owner;

	public BuffFieldEventParamBase param;
}
