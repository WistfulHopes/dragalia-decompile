using System.Collections.Generic;

namespace Gluon.Event;

public class Party : EventBase<Party>
{
	[Required]
	public Dictionary<int, int> memberCountTable;

	public int rankingType;

	public int reBattleCount;

	public bool isAutoFailTimeoutEnabled;

	public float forceAutoFailTime;

	public bool isDisableOnDamagedWhenLeave;
}
