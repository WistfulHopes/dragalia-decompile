using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsTanatosPlayerEffect : ActionParts
{
	[SerializeField]
	private TanatosPlayerEffectData _data;

	public override PartsData data => null;
}
