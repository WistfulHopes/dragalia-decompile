using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsAppearEnemy : ActionParts
{
	[SerializeField]
	private AppearEnemyData _data;

	public override PartsData data => null;
}
