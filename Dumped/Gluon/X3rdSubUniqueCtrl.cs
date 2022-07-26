using Gluon.ActionData;

namespace Gluon;

public class X3rdSubUniqueCtrl : EnemyUniqueCtrl
{
	private enum State
	{
		Init,
		Setup,
		WaitStart,
		Idle
	}

	private State _state;

	private SetupX3rdSubData _resource;

	private EnemyCharacter _inner2nd;

	private EnemyCharacter[] _tentacles;

	public override void Initialize()
	{
	}

	public override void FastUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	public void SetResource(SetupX3rdSubData data)
	{
	}

	private void ProcSetup()
	{
	}

	private void SetupInner2nd()
	{
	}

	private void SetupTentacle()
	{
	}

	private void ProcIdle()
	{
	}
}
