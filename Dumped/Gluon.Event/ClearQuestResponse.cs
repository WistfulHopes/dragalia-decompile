namespace Gluon.Event;

public class ClearQuestResponse : EventBase<ClearQuestResponse>
{
	[Required]
	public byte[] recordMultiResponse;

	[Required]
	public int clearTime;

	public bool isIgnoreRanking;
}
