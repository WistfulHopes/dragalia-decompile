using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsTeleport : ActionParts
{
	[SerializeField]
	private TeleportData _data;

	public override PartsData data => null;
}
