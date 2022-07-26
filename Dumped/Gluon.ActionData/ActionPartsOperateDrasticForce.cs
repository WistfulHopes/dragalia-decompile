using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsOperateDrasticForce : ActionParts
{
	[SerializeField]
	private OperateDrasticForceData _data;

	public override PartsData data => null;
}
