namespace Gluon.Event;

public class ApplyOpeningDebuffEvent : EventBase<ApplyOpeningDebuffEvent>
{
	[Required]
	public CharacterId target;
}
