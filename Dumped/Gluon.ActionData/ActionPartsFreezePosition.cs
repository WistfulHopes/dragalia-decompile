using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsFreezePosition : ActionParts
{
	[SerializeField]
	private FreesPositionData _data;

	public override PartsData data => null;
}
