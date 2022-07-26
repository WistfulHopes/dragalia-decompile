using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsSetupDrasticForce : ActionParts
{
	[SerializeField]
	private SetupDrasticForceData _data;

	public override PartsData data => null;
}
