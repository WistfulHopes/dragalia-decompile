using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsOperateCutt : ActionParts
{
	[SerializeField]
	private OperateCuttData _data;

	public override PartsData data => null;
}
