using System.Collections.Generic;
using Cute.Cri;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick;

public class RollingStone : DelayedGimmickBase
{
	private enum State
	{
		WaitStart,
		WaitInterval,
		Fall,
		WaitRolling,
		Rolling,
		Break
	}

	public GimmickRollingStone type;

	public List<GameObject> enemyGeneratorObject;

	private int enemyGeneratorCount;

	private bool popEndEvent;

	public bool fallType;

	public GameObject breakModel;

	public GameObject groundModel;

	public bool isApplyLightProbeParamToModel;

	protected Animator anim;

	protected Animator breakAnimator;

	private GimmickRollingStoneElement variation;

	private CollisionHitAttribute hitAttribute;

	private HashSet<int> victim;

	private Vector3 startPos;

	private float fallSpeed;

	private float waitTime;

	private float interval;

	private AudioPlayback loopSound;

	public string effectNameFall;

	public string effectNameMove;

	public string effectNameBreak;

	protected EffectObject effectMoveObj;

	private State state;

	protected GameObject shadowObject;

	private Transform _shadowObjTrans;

	private const float kShadowSizeCoef = 0.6f;

	public float shadowRadius;

	public float visibleDistance;

	private Renderer render;

	private long scheduledTime;

	private bool waitingGuestInterval;

	protected override void Awake()
	{
	}

	public void PopEndEvent()
	{
	}

	private void InitializeParam()
	{
	}

	public override void FastUpdate()
	{
	}

	private void Crush(Vector3 pos)
	{
	}

	private EffectObject PlayEffect(string effName, Vector3 pos, Quaternion quat)
	{
		return null;
	}

	private void OnTriggerStay(Collider other)
	{
	}

	protected override void OnDestroy()
	{
	}

	public override void OnEvent(DungeonObject eventObject, GameObject target)
	{
	}
}
