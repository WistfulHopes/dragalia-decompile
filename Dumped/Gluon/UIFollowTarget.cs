using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon;

public class UIFollowTarget : MonoBehaviour
{
	private RectTransform rectTransform;

	private FortScene fortScene;

	private Camera mainCamera;

	[SerializeField]
	public Vector2 gaugeScaleRange;

	public bool needChangeScale;

	public Vector3 positionOffset
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Transform target
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void OnInit(FortScene scene, [Optional] Transform transTarget)
	{
	}

	public void OnInit(FortScene scene, Vector3 offset, [Optional] Transform transTarget)
	{
	}

	protected void LateUpdate()
	{
	}

	public void UpdatePosition()
	{
	}
}
