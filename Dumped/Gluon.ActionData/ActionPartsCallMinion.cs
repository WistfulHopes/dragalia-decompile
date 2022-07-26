using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsCallMinion : ActionParts
{
	[SerializeField]
	private CallMinionData _data;

	public override PartsData data => null;
}
