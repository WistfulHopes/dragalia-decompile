namespace Gluon.Event;

public class DebugInspectionRequest : EventBase<DebugInspectionRequest>
{
	public enum RequestTypes
	{
		IngameState,
		LeaveReason,
		AutoFailTimeout,
		PlayQuestStartProcTime,
		ChangedCharaOwner,
		AiCheckReport
	}

	[Required]
	public RequestTypes requestType;
}
