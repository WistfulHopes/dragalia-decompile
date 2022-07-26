namespace Gluon.Event;

public class CharacterSpecialState : EventBase<CharacterSpecialState>
{
	public byte type;

	[Required]
	public CharacterId target;

	public int value;

	public float floatValue;

	public int[] values;
}
