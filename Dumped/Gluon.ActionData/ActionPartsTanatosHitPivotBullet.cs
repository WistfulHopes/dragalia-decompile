using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsTanatosHitPivotBullet : ActionPartsPivotBullet
{
	[SerializeField]
	private TanatosHitPivotBulletData _customData;

	public override PartsData data => null;
}
