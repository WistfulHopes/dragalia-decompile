namespace Gluon.Event;

public class RetryVoteEvent : EventBase<RetryVoteEvent>
{
	public enum RetryVoteEventTypes : byte
	{
		ChangeVoteState,
		GoToRetry,
		SetIsLastVote,
		GoToContinueImpossible,
		LostStartVoteRight,
		ToReady
	}

	public RetryVoteEventTypes type;

	public int value;

	public bool isLastVote;
}
