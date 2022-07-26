using System.Collections;
using UnityEngine;

namespace Gluon;

public class BRItemDirectionParam : MonoBehaviour
{
	public static BRItemDirectionParam instance;

	public static readonly float popDelayMin;

	public static readonly float popDelayMax;

	[SerializeField]
	private AnimationCurve popJumpAnimCurve;

	[SerializeField]
	private AnimationCurve popScaleAnimCurve;

	[SerializeField]
	private AnimationCurve popRotScaleAnimCurve;

	[SerializeField]
	private string popEffectLabel;

	[SerializeField]
	private string popSoundLabel;

	[SerializeField]
	public Vector3 idleOffset;

	[SerializeField]
	public float idleAddRotY;

	[SerializeField]
	private AnimationCurve cantCatchShakeAnimCurve;

	[SerializeField]
	private string cantCatchEffectLabel;

	[SerializeField]
	private string cantCatchSoundLabel;

	[SerializeField]
	private AnimationCurve caughtJumpAnimCurve;

	[SerializeField]
	private AnimationCurve caughtScaleAnimCurve;

	[SerializeField]
	private AnimationCurve caughtStalkAnimCurve;

	[SerializeField]
	private AnimationCurve caughtRotScaleAnimCurve;

	[SerializeField]
	private string caughtEffectLabel;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public float GetDirectionSecPop()
	{
		return default(float);
	}

	public void SetDirectionPop(Transform targetObj, Vector3 startPos, Vector3 endPos, bool ignoreSeFx)
	{
	}

	public IEnumerator CoDirectionPop(Transform targetObj, Vector3 startPos, Vector3 endPos, bool ignoreSeFx)
	{
		return null;
	}

	public void SetDirectionCantCatch(Transform targetObj)
	{
	}

	public IEnumerator CoDirectionCantCatch(Transform targetObj)
	{
		return null;
	}

	public void SetDirectionCaught(Transform targetObj, Transform stalkObj)
	{
	}

	public IEnumerator CoDirectionCaught(Transform targetObj, Transform stalkObj)
	{
		return null;
	}
}
