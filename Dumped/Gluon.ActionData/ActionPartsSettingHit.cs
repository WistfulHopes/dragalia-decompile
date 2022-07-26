using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsSettingHit : ActionParts
{
	[SerializeField]
	private SettingHitData _data;

	public override PartsData data => null;
}
