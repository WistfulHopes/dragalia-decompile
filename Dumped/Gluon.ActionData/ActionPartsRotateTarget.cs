using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsRotateTarget : ActionParts
{
	[SerializeField]
	private RotateTargetData _data;

	public override PartsData data => null;
}
