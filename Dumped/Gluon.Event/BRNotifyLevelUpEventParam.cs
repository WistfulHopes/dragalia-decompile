namespace Gluon.Event;

public class BRNotifyLevelUpEventParam : BRNotifyEventParamBase
{
	[Required]
	public CharacterId targetCharacter;

	[Required]
	public int level;
}
