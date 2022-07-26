using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsServant : ActionParts
{
	[SerializeField]
	private ServantData _data;

	public override PartsData data => null;
}
