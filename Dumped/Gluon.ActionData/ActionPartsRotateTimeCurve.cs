using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsRotateTimeCurve : ActionParts
{
	[SerializeField]
	private RotateTimeCurveData _data;

	public override PartsData data => null;
}
