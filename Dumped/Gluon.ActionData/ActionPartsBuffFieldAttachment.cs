using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsBuffFieldAttachment : ActionParts
{
	[SerializeField]
	private BuffFieldAttachmentData _data;

	public override PartsData data => null;
}
