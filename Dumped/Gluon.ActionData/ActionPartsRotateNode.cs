using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsRotateNode : ActionParts
{
	[SerializeField]
	private RotateNodeData _data;

	public override PartsData data => null;
}
