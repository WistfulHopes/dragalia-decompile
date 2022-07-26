using System.Collections.Generic;

namespace Gluon.Event;

public class ChangeAbility : EventBase<ChangeAbility>
{
	[Required]
	public CharacterId character;

	[Required]
	public List<AbilitySyncData> abilities;
}
