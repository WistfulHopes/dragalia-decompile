namespace Gluon.Event;

public class EnergyPoint : EventBase<EnergyPoint>
{
	[Required]
	public CharacterId character;

	[Required]
	public int[] ep;
}
