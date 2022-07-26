namespace Gluon.Event;

public class ClearQuestRequest : EventBase<ClearQuestRequest>
{
	[Required]
	public byte[] recordMultiRequest;
}
