using UnityEngine;

namespace Gluon;

public class CameraGroupCronos : CameraGroupCtrl
{
	[SerializeField]
	private Camera backgroundCamera;

	public override int GetRenderLayer(Material material)
	{
		return default(int);
	}

	private void LateUpdate()
	{
	}
}
