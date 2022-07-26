namespace Gluon.Event;

public class ConsumeUtpToRecoverHpEvent : EventBase<ConsumeUtpToRecoverHpEvent>
{
	[Required]
	public CharacterId owner;

	public int hp;

	public float prevHp;

	public float utp;

	public int recoveryHp;
}
