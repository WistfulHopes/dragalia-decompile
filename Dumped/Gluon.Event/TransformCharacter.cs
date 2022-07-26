namespace Gluon.Event;

public class TransformCharacter : EventBase<TransformCharacter>
{
	[Required]
	public CharacterId characterId;

	public bool isHuman;

	public bool isFinishDragon;

	public int dp;
}
