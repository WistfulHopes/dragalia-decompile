using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsSetupEventHeal : ActionParts
{
	[SerializeField]
	private SetupEventHealData _data;

	public override PartsData data => null;
}
