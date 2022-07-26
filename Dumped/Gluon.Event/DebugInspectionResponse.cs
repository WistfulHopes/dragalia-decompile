namespace Gluon.Event;

public class DebugInspectionResponse : EventBase<DebugInspectionResponse>
{
	[Required]
	public DebugInspectionRequest.RequestTypes requestType;

	[Required]
	public string report;
}
