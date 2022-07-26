using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsParabolaBullet : ActionPartsBulletWithMarkerBase
{
	[SerializeField]
	private ParabolaBulletData _data;

	public const float MAX_DURATION_AFTER_RUSH = 100f;

	public const float MAX_DROP_TIME = 100f;

	public override PartsData data => null;
}
