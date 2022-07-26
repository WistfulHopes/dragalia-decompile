namespace Gluon.Event;

public class ResetBuffRequest : EventBase<ResetBuffRequest>
{
	[Required]
	public CharacterId character;

	public int conditionId;

	public int abilityId;

	public int productId;
}
