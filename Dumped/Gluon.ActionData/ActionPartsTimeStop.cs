using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsTimeStop : ActionParts
{
	[SerializeField]
	private TimeStopData _data;

	public override PartsData data => null;
}
