using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsSetupAlloutAssault : ActionParts
{
	[SerializeField]
	private SetupAlloutAssaultData _data;

	public override PartsData data => null;
}
