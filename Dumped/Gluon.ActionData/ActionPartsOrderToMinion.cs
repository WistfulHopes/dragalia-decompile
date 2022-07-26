using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsOrderToMinion : ActionParts
{
	[SerializeField]
	private OrderToMinionData _data;

	public override PartsData data => null;
}
