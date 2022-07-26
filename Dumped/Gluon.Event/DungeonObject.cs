namespace Gluon.Event;

public class DungeonObject : EventBase<DungeonObject>
{
	public int serialNumber;

	public int randomSeed;

	public long scheduledTime;

	public CharacterId characterId;

	public DungeonObjectParameterBase param;
}
