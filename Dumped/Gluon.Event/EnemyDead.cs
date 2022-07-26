using System.Collections.Generic;

namespace Gluon.Event;

public class EnemyDead : EventBase<EnemyDead>
{
	[Required]
	public List<EnemyDeadSyncData> deadList;
}
