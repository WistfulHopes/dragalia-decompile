using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsSound : ActionParts
{
	[SerializeField]
	private SoundData _data;

	public override PartsData data => null;
}
