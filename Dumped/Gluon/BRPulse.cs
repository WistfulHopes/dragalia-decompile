using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon;

public class BRPulse : MonoBehaviour
{
	private List<BRPulsePoint> points;

	public float maxRadius;

	[SerializeField]
	private string actionHitAttributeName;

	[SerializeField]
	private float delaySec;

	[SerializeField]
	private float firstSlowRadius;

	[SerializeField]
	private float firstSlowSec;

	[SerializeField]
	private float firstSlowDamageRatio;

	[SerializeField]
	private float firstSlowDamageIntervalSec;

	[SerializeField]
	private float secondSlowRadius;

	[SerializeField]
	private float secondSlowSec;

	[SerializeField]
	private float secondSlowDamageRatio;

	[SerializeField]
	private float secondSlowDamageIntervalSec;

	[SerializeField]
	private float convergeSecAfterSecondSlow;

	[SerializeField]
	private float lastDamageRatio;

	[SerializeField]
	private float lastDamageIntervalSec;

	private HashSet<CharacterBase> contactCharas;

	private float damageTimer;

	private bool isBeforeStart;

	private float elapsedSec;

	private static readonly string pulseEffectLabel;

	private EffectObject pulseEffectObj;

	private static readonly float pulseEffectScale;

	private bool announced;

	private static readonly float pulseRadiusNotifyEventIntervalTime;

	private float pulseRadiusNotifyEventSendDelayTime;

	public Vector3 areaCirclePos
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

	public float areaCircleRadNow
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public HashSet<CharacterBase> ContactCharas => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void RegisterPoint(BRPulsePoint point)
	{
	}

	private void SetBrAreaData(bool hasAppeared)
	{
	}

	private void SetPulseEffectData(bool hasAppeared)
	{
	}

	public bool IsInside(Vector3 pos, float margin = 0f)
	{
		return default(bool);
	}

	public void ClearEffect()
	{
	}

	public void SendPulseRadius()
	{
	}
}
