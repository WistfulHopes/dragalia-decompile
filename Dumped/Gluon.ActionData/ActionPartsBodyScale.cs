using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsBodyScale : ActionParts
{
	[SerializeField]
	private BodyScaleData _data;

	public override PartsData data => null;
}
