using System.Collections.Generic;

namespace Gluon.Event;

public struct AuraEventCommandData
{
	[Required]
	public CharacterId to;

	[Required]
	public AuraEventCommandType commandType;

	public int multiPlayKey;

	public int auraId;

	public int auraType;

	public int targetType;

	public int level;

	public float rate;

	public float duration;

	public CharacterId from;

	public int actionId;

	public int skillId;

	public int productId;

	public int publishLevel;

	public Dictionary<int, int> maxLimitLevelDict;

	public RemoveBuffReason reason;

	public bool durationUpdate;

	public bool hideCaption;
}
