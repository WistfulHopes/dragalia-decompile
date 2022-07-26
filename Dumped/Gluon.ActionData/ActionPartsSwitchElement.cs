using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsSwitchElement : ActionParts
{
	[SerializeField]
	private SwitchElementData _data;

	public override PartsData data => null;
}
