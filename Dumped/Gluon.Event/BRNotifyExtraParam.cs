namespace Gluon.Event;

public class BRNotifyExtraParam : BRNotifyEventParamBase
{
	[Required]
	public CharacterId targetCharacter;

	[Required]
	public int value1;

	[Required]
	public int value2;

	[Required]
	public int value3;
}
