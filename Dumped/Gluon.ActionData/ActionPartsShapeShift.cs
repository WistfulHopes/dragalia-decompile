using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsShapeShift : ActionParts
{
	[SerializeField]
	private ShapeShiftData _data;

	public override PartsData data => null;
}
