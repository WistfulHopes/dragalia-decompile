using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsRoseToken : ActionParts
{
	[SerializeField]
	private RoseTokenData _data;

	public override PartsData data => null;
}
