using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsHumanCannon : ActionParts
{
	[SerializeField]
	private HumanCannonData _data;

	public override PartsData data => null;
}
