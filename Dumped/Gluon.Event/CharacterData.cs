namespace Gluon.Event;

public class CharacterData : EventBase<CharacterData>
{
	public int playerId;

	public HeroParam[] heroParams;

	public HeroParam[] unusedHeroParams;

	public HeroParamExData[] heroParamExs;
}
