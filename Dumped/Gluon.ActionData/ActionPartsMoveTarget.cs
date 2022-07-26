using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsMoveTarget : ActionParts
{
	[SerializeField]
	private MoveTargetData _data;

	public override PartsData data => null;
}
