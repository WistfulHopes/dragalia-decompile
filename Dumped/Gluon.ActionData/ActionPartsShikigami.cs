using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsShikigami : ActionParts
{
	[SerializeField]
	private ShikigamiData _data;

	public override PartsData data => null;
}
