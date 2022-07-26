using UnityEngine;

namespace Gluon.ActionData;

public class ActionPartsOperateShader : ActionParts
{
	[SerializeField]
	private OperateShaderData _data;

	public override PartsData data => null;
}
