namespace Gluon.Event;

public class ReduceSacrificeShieldHp : EventBase<ReduceSacrificeShieldHp>
{
	[Required]
	public CharacterId target;

	public float reduceSacrificeShieldHp;
}
