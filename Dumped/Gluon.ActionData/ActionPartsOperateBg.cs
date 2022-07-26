using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsOperateBg : ActionParts
{
	[SerializeField]
	private OperateBgData _data;

	public override PartsData data => null;
}
