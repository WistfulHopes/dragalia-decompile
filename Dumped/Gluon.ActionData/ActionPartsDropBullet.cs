using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsDropBullet : ActionPartsBulletWithMarkerBase
{
	[SerializeField]
	private DropBulletData _data;

	public override PartsData data => null;
}
