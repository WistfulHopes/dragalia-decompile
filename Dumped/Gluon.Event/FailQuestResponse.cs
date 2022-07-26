namespace Gluon.Event;

public class FailQuestResponse : EventBase<FailQuestResponse>
{
	public enum ResultTypes
	{
		Timeup,
		Clear
	}

	[Required]
	public ResultTypes resultType;
}
