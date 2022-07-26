namespace Gluon.Event;

public class RecoveryHpRequest : EventBase<RecoveryHpRequest>
{
	public CharacterId character;

	public CharacterId from;

	public int healValue;

	public byte characterType;

	public short elementIndex;

	public int actionId;

	public int productId;

	public int bulletId;

	public int skillId;

	public int followerAvoid;
}
