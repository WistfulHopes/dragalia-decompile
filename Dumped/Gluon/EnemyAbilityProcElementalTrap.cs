using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon;

public class EnemyAbilityProcElementalTrap : EnemyAbilityProcBase
{
	private enum BurstStates
	{
		None,
		Small,
		Big
	}

	private ElementalType _element;

	private AbnormalStatusType _abnormal;

	private bool _eitherAbnormal;

	private float _sqrRange;

	private BurstStates _burstState;

	private float _timer;

	private List<int> _hasReservedBurst;

	private AbnormalStatusType[,] _elementAbnormal;

	private string[] EFF_TRAP;

	private string[] EFF_LAMP;

	private string[] EFF_EXPLOSION;

	private string EFF_ABNORMAL_ICON;

	private EffectObject _eoTrap;

	private EffectObject _eoLamp;

	private EffectObject _eoAbnormalIcon;

	private Vector3 _effScaleTrap;

	private Vector3 _effScaleExplosion;

	private Vector3 _effScaleExplosionBig;

	private const float ABNORMAL_ICON_OFFSET_Y = 2f;

	private const string SE_EXPLOSION = "SE_RAID_0160001_009";

	private CollisionHitAttribute hitAttribute
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

	private int effTrigAbnormal => default(int);

	public EnemyAbilityProcElementalTrap(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
	{
	}

	public override void Setup()
	{
	}

	public override void Play()
	{
	}

	public override void Stop()
	{
	}

	public override void OnUpdate()
	{
	}

	public void SetupTrap(ElementalType element, bool either)
	{
	}

	public void ForcedBurst()
	{
	}

	private EffectObject PlayEffect2(string effName, Vector3 scale, int effTrigger = 8, float offsetY = 0f)
	{
		return null;
	}

	public void StopEffect2(ref EffectObject eo)
	{
	}

	public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData)
	{
	}

	private void ReserveBurst(int popCount)
	{
	}

	private int CancelReservedBurst(int popCount)
	{
		return default(int);
	}

	private bool hasReservedBurst(int popCount)
	{
		return default(bool);
	}

	public override void OnRevive()
	{
	}
}
