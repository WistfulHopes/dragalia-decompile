using System.Collections.Generic;

namespace Gluon.Event;

public class AuraEvent : EventBase<AuraEvent>
{
	[Required]
	public List<AuraEventCommandData> commands;
}
