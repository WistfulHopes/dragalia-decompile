using UnityEngine;

namespace Gluon.Event;

public class FireSpecialBullet : EventBase<FireSpecialBullet>
{
	[Required]
	public CharacterId character;

	public int actionProductId;

	public Quaternion rotation;

	public Vector3 aimingPoint;
}
