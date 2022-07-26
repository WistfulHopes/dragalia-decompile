using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsButterflyBullet : ActionParts
{
	[SerializeField]
	private ButterflyBulletData _data;

	public override PartsData data => null;
}
