using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsEnemyBoost : ActionParts
{
	[SerializeField]
	private EnemyBoostData _data;

	public override PartsData data => null;
}
