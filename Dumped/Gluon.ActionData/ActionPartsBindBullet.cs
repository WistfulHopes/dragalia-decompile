using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsBindBullet : ActionPartsBulletWithMarkerBase
{
	[SerializeField]
	private BindBulletData _data;

	public override PartsData data => null;
}
