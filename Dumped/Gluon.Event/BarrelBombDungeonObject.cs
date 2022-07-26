using UnityEngine;

namespace Gluon.Event;

public class BarrelBombDungeonObject : DungeonObjectParameterBase
{
	public enum BarrelEventType
	{
		Set,
		Explosion
	}

	public Vector3 position;

	public BarrelEventType type;

	public int explosionCounterFromMulti;

	public int barrelBombindex;
}
