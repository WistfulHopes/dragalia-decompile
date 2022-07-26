using UnityEngine;

namespace Gluon.Event;

public class CallMinionEvent : EventBase<CallMinionEvent>
{
	public int taskId;

	[Required]
	public CharacterId caller;

	[Required]
	public string label;

	public int baseType;

	public Vector3 position;

	public bool editDirection;

	public Quaternion rotation;

	public float areaRadius;

	public uint randomSeed;
}
