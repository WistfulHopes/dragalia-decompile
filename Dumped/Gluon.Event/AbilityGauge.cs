namespace Gluon.Event;

public class AbilityGauge : EventBase<AbilityGauge>
{
	[Required]
	public CharacterId character;

	[Required]
	public int[] gaugeValueList;
}
