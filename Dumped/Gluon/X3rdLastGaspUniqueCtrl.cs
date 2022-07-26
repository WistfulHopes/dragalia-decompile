using Gluon.Event;

namespace Gluon;

public class X3rdLastGaspUniqueCtrl : EnemyUniqueCtrl
{
	private enum State
	{
		Idle,
		BeginLastGasp,
		UpdateLastGasp,
		Dead,
		End
	}

	private State _state;

	private int _deadActionId;

	private CollisionHitAttribute _hitAttribute;

	private float _hitInterval;

	private float _timer;

	private bool _hasReceivedX3rdLastGaspEnd;

	public override void Initialize()
	{
	}

	public void Setup(int deadActionId, string hitAttrLabel, float interval)
	{
	}

	public override void FastUpdate()
	{
	}

	public bool OnFatal(bool isQuestSkill, CharacterBase attacker)
	{
		return default(bool);
	}

	private void ProcBeginLastGasp()
	{
	}

	private void ProcUpdateLastGasp()
	{
	}

	private void ProcDead()
	{
	}

	public void SendX3rdLastGaspEndEvent()
	{
	}

	public override void OnReceiveCharacterSpecialState(CharacterSpecialState recvEvent)
	{
	}
}
