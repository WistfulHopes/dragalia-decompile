namespace Gluon.Event;

public class ChangeBuffDuration : EventBase<ChangeBuffDuration>
{
	[Required]
	public CharacterId character;

	[Required]
	public int category;

	[Required]
	public CharacterBuffType type;

	[Required]
	public int multiPlayKey;

	[Required]
	public float durationSec;
}
