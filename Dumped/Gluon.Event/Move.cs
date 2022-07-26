using UnityEngine;

namespace Gluon.Event;

public class Move : EventBase<Move>
{
	public CharacterId characterId;

	public Vector3 position;

	public float rotation;

	public byte flags;

	public int moveEventTimestamp;
}
