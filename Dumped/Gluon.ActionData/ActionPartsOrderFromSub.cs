using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsOrderFromSub : ActionParts
{
	[SerializeField]
	private OrderFromSubData _data;

	public override PartsData data => null;
}
