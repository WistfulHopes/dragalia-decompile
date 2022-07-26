using UnityEngine;

namespace Gluon;

public class SafetyZoneComponent : MonoBehaviour
{
	public enum Shape
	{
		None,
		Sphere,
		Cube
	}

	[SerializeField]
	private int _invalidActionId;

	[SerializeField]
	private int[] _invalidActionIdArray;

	[SerializeField]
	private Shape _shape;

	[SerializeField]
	private float _length;

	[SerializeField]
	private float _width;

	[SerializeField]
	private float _height;

	[SerializeField]
	private bool _isCheckHitCollisionForward;

	public int invalidActionId => default(int);

	public int[] invalidActionIdList => null;

	public Shape shape => default(Shape);

	public float length => default(float);

	public float width => default(float);

	public float height => default(float);

	public bool isCheckHitByCollisionForward => default(bool);
}
