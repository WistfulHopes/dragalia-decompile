namespace Gluon.Event;

public class SkillPoint : EventBase<SkillPoint>
{
	[Required]
	public CharacterId character;

	[Required]
	public int[] sp;
}
