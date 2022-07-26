using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsAppearMultiWeak : ActionParts
{
	[SerializeField]
	private AppearMultiWeakData _data;

	public override PartsData data => null;
}
