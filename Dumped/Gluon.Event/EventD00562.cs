using UnityEngine;

namespace Gluon.Event;

public class EventD00562 : EventBase<EventD00562>
{
	[Required]
	public CharacterId target;

	[Required]
	public CharacterId clawEnemy;

	public int actionId;

	public short actionPartsIndex;

	public Vector3 position;
}
