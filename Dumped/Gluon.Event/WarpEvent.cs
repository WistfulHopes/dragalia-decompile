namespace Gluon.Event;

public class WarpEvent : EventBase<WarpEvent>
{
	public enum WarpEventTypes : byte
	{
		LockRequest,
		UnlockRequest,
		Lock,
		Unlock
	}

	public WarpEventTypes type;

	public int roomGroup;

	public int doorKind;

	public bool checkIsDead;

	public bool isForceReturn;

	public int lockActorId;

	public CharacterId lockMultiPlayId;

	public bool isSuccess;
}
