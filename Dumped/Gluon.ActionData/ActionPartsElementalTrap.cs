using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsElementalTrap : ActionParts
{
	[SerializeField]
	private ElementalTrapData _data;

	public override PartsData data => null;
}
