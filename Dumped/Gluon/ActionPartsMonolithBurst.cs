using System.Collections.Generic;
using Gluon.ActionData;

namespace Gluon;

public class ActionPartsMonolithBurst : ActionParts
{
	private enum State
	{
		Wait,
		Attack
	}

	private readonly MonolithBurstData _partsData;

	private State _state;

	private CollisionHitAttribute _hitAttribute;

	private float _waiting;

	private int _powerNum;

	private List<int> _checkChildID;

	public ActionPartsMonolithBurst(Gluon.ActionData.ActionParts resource)
	{
	}

	public override void Initialize(CharacterBase chara)
	{
	}

	protected override void OnStart()
	{
	}

	protected override bool OnUpdate(float delta)
	{
		return default(bool);
	}
}
