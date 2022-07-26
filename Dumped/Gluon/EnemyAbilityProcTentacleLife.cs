using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon;

public class EnemyAbilityProcTentacleLife : EnemyAbilityProcBase
{
	public enum State
	{
		Idle,
		OnDown,
		Down,
		Standup,
		PlayedQTE
	}

	private float _timer;

	private const float STOP_TIMING = 2f;

	public State state
	{
		[CompilerGenerated]
		get
		{
			return default(State);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public EnemyAbilityProcTentacleLife(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
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

	public override void OnFatalAttack(ref EnemyAbility.Argument arg)
	{
	}

	public override void OnPlayQTECutt()
	{
	}

	public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData)
	{
	}
}
