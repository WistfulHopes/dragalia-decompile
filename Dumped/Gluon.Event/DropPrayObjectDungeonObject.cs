using UnityEngine;

namespace Gluon.Event;

public class DropPrayObjectDungeonObject : DungeonObjectParameterBase
{
	public enum DropPrayObjectEventType
	{
		Set,
		Hit
	}

	public Vector3 position;

	public DropPrayObjectEventType type;

	public int dropPrayObjectindex;

	public CharacterId characterId;

	public Quaternion rotation;

	public bool showMarker;

	public CharacterId markerOwner;

	public float lifeTime;
}
