using UnityEngine;

namespace Gluon.Event;

public class BarrieredHit : EventBase<BarrieredHit>
{
	public CharacterId targetEnemy;

	public int from;

	[ActionId]
	public int actionId;

	public Vector3 hitPos;

	public bool isFromAdditionalAttack;
}
