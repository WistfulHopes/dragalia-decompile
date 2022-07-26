using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsDeathTimer : ActionParts
{
	[SerializeField]
	private DeathTimerData _data;

	public override PartsData data => null;
}
