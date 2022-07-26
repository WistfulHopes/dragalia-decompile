using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsPartySwitch : ActionParts
{
	[SerializeField]
	private PartySwitchData _data;

	public override PartsData data => null;
}
