namespace Gluon.Event;

public class BulletEvent : EventBase<BulletEvent>
{
	public enum BulletEventTypes : byte
	{
		None,
		HitProcess,
		TargetChanged,
		ShikigamiLevelUp,
		ShikigamiRemove,
		ShikigamiDuration,
		SyncMove
	}

	public BulletEventTypes type;

	[Required]
	public CharacterId character;

	public int bulletId;

	public byte flags;

	public CharacterId target;

	public int level;

	public float duration;

	public BulletEventParamBase param;
}
