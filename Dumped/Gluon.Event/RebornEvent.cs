using System.Collections.Generic;

namespace Gluon.Event;

public class RebornEvent : EventBase<RebornEvent>
{
	public enum RebornEventTypes : byte
	{
		Wait,
		Reborn
	}

	public RebornEventTypes type;

	public List<CharacterId> targetCharas;

	public List<float> rebornHpRatios;

	public bool isAbilityReborn;
}
