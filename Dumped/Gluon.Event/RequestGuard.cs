namespace Gluon.Event;

public class RequestGuard : EventBase<RequestGuard>
{
	public ushort requestId;

	public CharacterId targetEnemy;
}
