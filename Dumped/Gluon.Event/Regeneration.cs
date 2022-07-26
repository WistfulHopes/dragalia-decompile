using System.Collections.Generic;

namespace Gluon.Event;

public class Regeneration : EventBase<Regeneration>
{
	[Required]
	public CharacterId target;

	public short type;

	[Required]
	public int[] healValues;

	public Dictionary<CharacterId, int> froms;

	public int damageValue;

	public bool isFollower;

	public int uniqueIconType;

	public float dragonTimerDamage;

	public int buffIconId;
}
