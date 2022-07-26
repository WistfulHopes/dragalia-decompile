using UnityEngine;

namespace Gluon.Event;

public class Charge : EventBase<Charge>
{
	[Required]
	public CharacterId characterId;

	public float rotation;

	public float pullLength;

	public Vector3 markerPos;
}
