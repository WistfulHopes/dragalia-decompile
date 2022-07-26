namespace Gluon.Event;

public class CharacterStateExtraSync : EventBase<CharacterStateExtraSync>
{
	public CharacterId character;

	public byte state;

	public CharacterStateExtraSyncBody body;
}
