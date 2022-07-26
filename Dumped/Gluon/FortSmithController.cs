using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Gluon;

public class FortSmithController : MonoBehaviour
{
	public enum SmithState
	{
		None,
		Born,
		AfterBornAnimation,
		Idle,
		Build,
		AfterBuildAnimation,
		Quit,
		Destroy
	}

	public delegate void animationEndDelegate();

	private SmithState state;

	protected animationEndDelegate animationEndCallback;

	private bool _isDisp;

	[SerializeField]
	public float fallDistance;

	public float moveDuration;

	private float effDuration;

	private float totalTime;

	public float buildEffectPosOffset;

	private Vector3 offsetVec;

	[SerializeField]
	private float effectPosOffsetDis;

	[SerializeField]
	private Transform transCenter;

	private bool _isAreeaExtension;

	private Renderer[] smithRenderers;

	private EffectObject effectObj;

	private Renderer[] effectRenderers;

	private int buildSECount;

	[SerializeField]
	private int buildSEMaxCount;

	[SerializeField]
	private float volumnFadeOutFactor;

	private Vector3 buildPos;

	private Tweener idleMoveTweener;

	private const float reverseSmithRotationX = 60f;

	private static readonly Vector3 reverseSmithRotationEuler;

	public Animator animator
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool isDisp
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool isAreeaExtension
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public void AddAnimationEndCallback(animationEndDelegate callback)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private Vector3 GetBornEffectPos(Vector3 targetPos)
	{
		return default(Vector3);
	}

	public void SetState(SmithState smithState)
	{
	}

	public void ShowBuildEffect()
	{
	}

	public void MoveUpward()
	{
	}

	public void Disp(bool flag)
	{
	}

	private void SetEffectOrder(GameObject go, Vector3 targetPos)
	{
	}

	private Vector3 GetEffectPosOffset()
	{
		return default(Vector3);
	}

	public void ShowQuitAnimation()
	{
	}

	private void OnDestroy()
	{
	}

	private Vector3 GetRisingRotation(Quaternion localRotation)
	{
		return default(Vector3);
	}
}
