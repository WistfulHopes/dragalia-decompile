using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Event;

public class BindEvent : EventBase<BindEvent>
{
	public enum Types
	{
		Catch,
		Confirm,
		Release
	}

	public Types eventType;

	public long bindEventId;

	public CharacterId owner;

	public List<CharacterId> targets;

	public Vector3 position;

	public byte flags;

	public byte effectTrigger;
}
