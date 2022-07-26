using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsFormationBullet : ActionParts
{
	[SerializeField]
	private FormationBulletData _data;

	public override PartsData data => null;
}
