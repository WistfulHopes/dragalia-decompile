using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsNavigateNPC : ActionParts
{
	[SerializeField]
	private NavigateNPCData _data;

	public override PartsData data => null;
}
