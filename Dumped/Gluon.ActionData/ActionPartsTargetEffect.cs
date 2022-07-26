using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsTargetEffect : ActionParts
{
	[SerializeField]
	private TargetEffectData _data;

	public override PartsData data => null;
}
