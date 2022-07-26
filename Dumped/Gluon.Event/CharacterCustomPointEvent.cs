namespace Gluon.Event;

public class CharacterCustomPointEvent : EventBase<CharacterCustomPointEvent>
{
	[Required]
	public int type;

	[Required]
	public CharacterId target;

	[Required]
	public int index;

	[Required]
	public int value;
}
