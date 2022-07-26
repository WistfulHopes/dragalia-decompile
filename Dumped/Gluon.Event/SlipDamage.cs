using System.Collections.Generic;

namespace Gluon.Event;

public class SlipDamage : EventBase<SlipDamage>
{
	[Required]
	public CharacterId target;

	public short type;

	public int damage;

	public CharacterId attacker;

	public bool isFollower;

	public Dictionary<CharacterId, int> froms;
}
