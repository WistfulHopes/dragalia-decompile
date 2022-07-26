using UnityEngine;

namespace Gluon.Event;

public class AreaTrapDungeonObject : DungeonObjectParameterBase
{
	public enum AreaTrapEventType
	{
		Set
	}

	public Vector3 position;

	public AreaTrapEventType type;

	public int areaTrapBombindex;
}
