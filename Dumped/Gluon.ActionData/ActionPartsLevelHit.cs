using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsLevelHit : ActionParts
{
	[SerializeField]
	private LevelHitData _data;

	public override PartsData data => null;
}
