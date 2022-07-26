using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsMarker : ActionParts
{
	[SerializeField]
	private MarkerData _data;

	public override PartsData data => null;
}
