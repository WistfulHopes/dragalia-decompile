namespace Gluon.Event;

public class WillLeave : EventBase<WillLeave>
{
	public enum Reasons
	{
		None,
		Retire,
		LeaveAlone,
		BRContinueRetire
	}

	public Reasons reason;
}
