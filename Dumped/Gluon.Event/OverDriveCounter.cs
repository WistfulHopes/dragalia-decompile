namespace Gluon.Event;

public class OverDriveCounter : EventBase<OverDriveCounter>
{
	[Required]
	public CharacterId owner;

	[Required]
	public CharacterId target;
}
