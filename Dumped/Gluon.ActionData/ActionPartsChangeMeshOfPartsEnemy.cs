using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsChangeMeshOfPartsEnemy : ActionParts
{
	[SerializeField]
	private ChangeMeshOfPartsEnemyData _data;

	public override PartsData data => null;
}
