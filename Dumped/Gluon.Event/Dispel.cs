namespace Gluon.Event;

public class Dispel : EventBase<Dispel>
{
	[Required]
	public CharacterId target;

	public int actionId;

	[Required]
	public CharacterId from;
}
