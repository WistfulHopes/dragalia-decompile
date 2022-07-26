using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsMotion : ActionParts
{
	[SerializeField]
	private PartsMotionData _data;

	public override PartsData data => null;
}
