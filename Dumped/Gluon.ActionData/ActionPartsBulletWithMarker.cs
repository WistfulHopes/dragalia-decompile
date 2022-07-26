using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsBulletWithMarker : ActionPartsBulletWithMarkerBase
{
	[SerializeField]
	private BulletWithMarkerData _data;

	public override PartsData data => null;
}
