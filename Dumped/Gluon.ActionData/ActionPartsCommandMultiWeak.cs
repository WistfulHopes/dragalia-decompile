using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsCommandMultiWeak : ActionParts
{
	[SerializeField]
	private CommandMultiWeakData _data;

	public override PartsData data => null;
}
