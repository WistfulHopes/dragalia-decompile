using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsActUI : ActionParts
{
	[SerializeField]
	private ActUIData _data;

	public override PartsData data => null;
}
