namespace Gluon.Event;

public class DenyGuard : EventBase<DenyGuard>
{
	public ushort requestId;

	public CharacterId guardExecEnemy;
}
