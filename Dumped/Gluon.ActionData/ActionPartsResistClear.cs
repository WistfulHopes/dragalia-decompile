using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsResistClear : ActionParts
{
	[SerializeField]
	private ResistClearData _data;

	public override PartsData data => null;
}
