using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsRotate : ActionParts
{
	[SerializeField]
	private RotateData _data;

	public override PartsData data => null;
}
