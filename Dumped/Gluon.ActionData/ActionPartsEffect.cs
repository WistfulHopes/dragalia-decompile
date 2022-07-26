using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsEffect : ActionParts
{
	public enum InspectorDisplayType
	{
		Normal,
		HitEffect
	}

	[SerializeField]
	private EffectData _data;

	public override PartsData data => null;
}
