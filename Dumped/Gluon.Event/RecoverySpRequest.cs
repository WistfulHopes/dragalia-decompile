namespace Gluon.Event;

public class RecoverySpRequest : EventBase<RecoverySpRequest>
{
	public CharacterId character;

	public float healRatio;

	public int healSkillIndex;

	public bool isHumanOnly;

	public int healValue;

	public bool isDragonOnly;
}
