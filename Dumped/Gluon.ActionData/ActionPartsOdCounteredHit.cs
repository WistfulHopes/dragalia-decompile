using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsOdCounteredHit : ActionParts
{
	[SerializeField]
	private OdCounteredHitData _data;

	public override PartsData data => null;
}
