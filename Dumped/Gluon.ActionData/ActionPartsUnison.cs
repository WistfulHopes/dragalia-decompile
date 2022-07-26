using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsUnison : ActionParts
{
	[SerializeField]
	private UnisonData _data;

	public override PartsData data => null;
}
