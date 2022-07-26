namespace Gluon.Event;

public class DebuffExtraDamage : EventBase<DebuffExtraDamage>
{
	[Required]
	public CharacterId target;

	[ActionConditionId]
	public int actionConditionId;

	public int damage;

	public CharacterId from;

	public float extraElementRate;

	public uint hitAttrCrc32;

	public int actionId;

	public bool isHostSync;

	public int buffExplosionHitId;

	public bool isPropagation;
}
