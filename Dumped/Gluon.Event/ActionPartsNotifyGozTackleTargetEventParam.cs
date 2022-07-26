namespace Gluon.Event;

public class ActionPartsNotifyGozTackleTargetEventParam : ActionPartsNotifyEventParamBase
{
	[Required]
	public CharacterId tackleTarget;

	[Required]
	public int tackleNo;
}
