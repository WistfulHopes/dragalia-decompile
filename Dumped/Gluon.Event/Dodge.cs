namespace Gluon.Event;

public class Dodge : EventBase<Dodge>
{
	[Required]
	public CharacterId owner;

	public bool showDodge;

	public CharacterId attacker;
}
