namespace Gluon.Event;

public class TransSkill : EventBase<TransSkill>
{
	public CharacterId target;

	public bool isDragon;

	public int skillIndex;

	public int currentSkillId;

	public int transSkillId;
}
