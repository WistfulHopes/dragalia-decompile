using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsMultiBullet : ActionParts
{
	[SerializeField]
	private MultiBulletData _data;

	public override PartsData data => null;
}
