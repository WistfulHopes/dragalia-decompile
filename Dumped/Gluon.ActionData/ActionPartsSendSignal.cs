using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsSendSignal : ActionParts
{
	[SerializeField]
	private SendSignalData _data;

	public override PartsData data => null;
}
