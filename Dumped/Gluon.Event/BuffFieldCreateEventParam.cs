using UnityEngine;

namespace Gluon.Event;

public class BuffFieldCreateEventParam : BuffFieldEventParamBase
{
	[Required]
	public long actionPartsResourceId;

	[Required]
	public uint hitAttrLabelCrc32;

	[Required]
	public Vector3 position;

	[Required]
	public Quaternion rotation;

	[Required]
	public int actionId;

	[Required]
	public int skillId;

	[Required]
	public int actionProductId;

	[Required]
	public float skillDamageUpBuffRate;

	[Required]
	public int warpRoomGroupId;

	[Required]
	public bool isHostRequest;

	public int tensionLevel;

	public int inspirationLevel;
}
