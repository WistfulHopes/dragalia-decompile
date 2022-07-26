namespace Gluon.Event;

public class Dead : EventBase<Dead>
{
	[Required]
	public CharacterId character;

	public short popCount;
}
