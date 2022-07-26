namespace Gluon.Event;

public class FailQuestRequest : EventBase<FailQuestRequest>
{
	public enum FailTypes
	{
		Timeup,
		AllDead
	}

	[Required]
	public FailTypes failType;
}
