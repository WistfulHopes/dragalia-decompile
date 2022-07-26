using UnityEngine;

namespace Gluon.Event;

public class AttackHit : EventBase<AttackHit>
{
	public CharacterId from;

	public int damage;

	public int breakDamage;

	[Required]
	public CharacterId to;

	public Vector3 hitPos;

	public int bulletId;

	public float elementRate;

	public int applyAbnormalStatusResult;

	public bool isCritical;

	public float rotation;

	public int reaction;

	public KnockBack knockBack;

	public Absorption absorption;

	public BlastUp blastUp;

	public BlastDown blastDown;

	public BlastSp blastSp;

	[ActionId]
	public int actionId;

	[SkillIdOrZero]
	public int skillId;

	public int hitProduction;

	public CharacterId additionalAttackFrom;

	public byte flags;

	public int moveEventTimestamp;

	public float dragonTimerDamage;

	public float skillDamageUpBuffRate;

	public byte characterType;

	public short elementIndex;

	public int productId;

	public float burstDamageUpBuffRate;

	public long designatedHitEffectResourceId;

	public uint hitAttrLabelCrc32;

	public int buffCount;

	public byte flags2;

	public short popCount;

	public void Clear()
	{
	}
}
