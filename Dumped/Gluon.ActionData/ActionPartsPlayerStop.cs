using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsPlayerStop : ActionParts
{
	[SerializeField]
	private PlayerStopData _data;

	public override PartsData data => null;
}
