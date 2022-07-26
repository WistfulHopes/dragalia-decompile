using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsNevOption : ActionParts
{
	[SerializeField]
	private NevOptionData _data;

	public override PartsData data => null;
}
