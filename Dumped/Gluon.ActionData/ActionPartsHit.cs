using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsHit : ActionParts
{
	[SerializeField]
	private HitData _data;

	public override PartsData data => null;
}
