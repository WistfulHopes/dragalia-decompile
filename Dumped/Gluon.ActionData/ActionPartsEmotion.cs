using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsEmotion : ActionParts
{
	[SerializeField]
	private EmotionData _data;

	public override PartsData data => null;
}
