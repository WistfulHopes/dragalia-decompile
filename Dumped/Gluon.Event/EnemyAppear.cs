using System.Collections.Generic;

namespace Gluon.Event;

public class EnemyAppear : EventBase<EnemyAppear>
{
	[Required]
	public List<EnemyAppearSyncData> appearList;
}
