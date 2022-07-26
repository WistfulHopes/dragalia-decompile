using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsMonolithBurst : ActionParts
{
	[SerializeField]
	private MonolithBurstData _data;

	public override PartsData data => null;
}
