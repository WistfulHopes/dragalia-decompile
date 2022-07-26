using System.Collections.Generic;
using Gluon.Event;
using Gluon.Master;

namespace Gluon;

public class EnemyAbilityProcMeteorStrike : EnemyAbilityProcBase
{
	private List<ElementalType> _listElemental;

	private List<EnemyCharacter> _listLinks;

	private RandomXorshift _random;

	private bool _isNextAction;

	private float _timer;

	private string[] EFF_ELEMENTAL;

	private const float NO_ELEMENTAL_OFFSET_Y = 1f;

	private float _timeSyncIntervalTimer;

	private const float TIME_SYNC_INTERVAL = 5f;

	public EnemyAbilityProcMeteorStrike(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
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

	public override void OnActionParts(bool onoff)
	{
	}

	private void SelectLinkedEnemy(int linkNum)
	{
	}

	private void SetupLinkedEnemy()
	{
	}

	private void ShuffleElement(List<ElementalType> list)
	{
	}

	public override void CreateCharacterMarkRelationUI()
	{
	}

	public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData)
	{
	}
}
