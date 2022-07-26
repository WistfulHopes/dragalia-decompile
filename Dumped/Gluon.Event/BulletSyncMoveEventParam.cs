using UnityEngine;

namespace Gluon.Event;

public class BulletSyncMoveEventParam : BulletEventParamBase
{
	[Required]
	public Vector3 position;
}
