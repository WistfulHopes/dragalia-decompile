namespace Gluon.Event;

public class GameStart : EventBase<GameStart>
{
	[Required]
	public int[] actorIds;
}
