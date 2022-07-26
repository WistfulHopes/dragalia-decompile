using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsVisible : ActionParts
{
	[SerializeField]
	private VisibleData _data;

	public override PartsData data => null;
}
