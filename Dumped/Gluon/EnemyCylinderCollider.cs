using Cute.Core;
using UnityEngine;

namespace Gluon;

public class EnemyCylinderCollider : FastUpdateMonoBehaviour
{
	private MeshCollider _meshCollider;

	private const int CYLINDER_ANGLE = 360;

	private const int VERTICES_NUM = 12;

	[SerializeField]
	private float _radius;

	[SerializeField]
	private float _height;

	[SerializeField]
	private Vector3 _offset;

	[SerializeField]
	private float _pushPowerRate;

	[SerializeField]
	private bool _floorAlignment;

	[SerializeField]
	private bool _lieDown;

	private float _oldRadius;

	private float _oldHeight;

	private Vector3 _oldOffset;

	private Vector2 meshColliderCenterPositionXZ;

	private Vector2 charaColliderCenterPositionXZ;

	public float radius => default(float);

	public float height => default(float);

	protected MeshCollider meshCollider => null;

	private void Awake()
	{
	}

	public void CreateCylinderCollider(float radius, float height, int fanAngle, Vector3 offset, int numVertices = 32)
	{
	}

	private Mesh CreateMesh(float radius, float height, Vector3 offSet, int angle, int numVertices)
	{
		return null;
	}

	private void LateUpdate()
	{
	}
}
