using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsAutomaticFire : ActionParts
{
	[SerializeField]
	private AutomaticFireData _data;

	public override PartsData data => null;
}
