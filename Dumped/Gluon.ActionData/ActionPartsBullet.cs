using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsBullet : ActionParts
{
	[SerializeField]
	private BulletData _data;

	public override PartsData data => null;
}
