using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsMultiMove : ActionParts
{
	[SerializeField]
	private MultiMoveData _data;

	public override PartsData data => null;
}
