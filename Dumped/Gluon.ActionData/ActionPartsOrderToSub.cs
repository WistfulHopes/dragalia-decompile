using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsOrderToSub : ActionParts
{
	[SerializeField]
	private OrderToSubData _data;

	public override PartsData data => null;
}
