using UnityEngine;

namespace Gluon.Event;

public class AppearEnemyEvent : EventBase<AppearEnemyEvent>
{
	public int taskId;

	[Required]
	public CharacterId owner;

	[Required]
	public CharacterId popEnemy;

	public CharacterId target;

	public Vector3 popPos;

	public Quaternion popRot;

	public int childActionid;

	public byte flags;
}
