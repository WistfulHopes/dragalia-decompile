namespace Gluon.Event;

public struct EnemyDeadSyncData
{
	[Required]
	public CharacterId character;

	public ushort popCount;

	public DeadReason reason;
}
