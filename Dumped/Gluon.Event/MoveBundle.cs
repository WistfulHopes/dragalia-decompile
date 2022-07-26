namespace Gluon.Event;

public class MoveBundle : EventBase<MoveBundle>
{
	[Required]
	public MoveBundleUnit[] moves;
}
