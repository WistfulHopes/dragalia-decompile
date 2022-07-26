using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsMove : ActionParts
{
	[SerializeField]
	private MoveData _data;

	public override PartsData data => null;
}
