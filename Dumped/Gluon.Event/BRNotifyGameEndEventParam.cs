namespace Gluon.Event;

public class BRNotifyGameEndEventParam : BRNotifyEventParamBase
{
	[Required]
	public CharacterId winnerCharacter;

	[Required]
	public CharacterId lastDeadCharacter;
}
