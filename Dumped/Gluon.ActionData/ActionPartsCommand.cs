using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsCommand : ActionParts
{
	[SerializeField]
	private CommandData _data;

	public override PartsData data => null;
}
