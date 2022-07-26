using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsPivotBullet : ActionPartsBulletWithMarkerBase
{
	[SerializeField]
	private PivotBulletData _data;

	public override PartsData data => null;
}
