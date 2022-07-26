namespace Gluon.Event;

public class ActionPartsNotifyGozTackleInitEventParam : ActionPartsNotifyEventParamBase
{
	[Required]
	public CharacterId[] tackleTargets;
}
